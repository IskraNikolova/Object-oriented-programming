using System.Collections.Generic;
using System.Runtime.InteropServices;
using NightlifeEntertainment.Interfaces;

namespace NightlifeEntertainment
{
    using System;
    using System.Linq;
    using NightlifeEntertainment.Models.Performances;
    using NightlifeEntertainment.Models.Tickets;
    using NightlifeEntertainment.Models.Venues;

    public class NewCinemaEngine : CinemaEngine
    {
        protected override void ExecuteFindCommand(string[] commandWords)
        {
            string word = commandWords[1];
            this.Output.AppendLine($"Search for \"{word}\"");
            this.Output.AppendLine("Performances:");

            string matchesWord = word.ToLower();
            DateTime dateTime = DateTime.Parse(commandWords[2] + " " + commandWords[3]);

            List<IPerformance> performancesMatches = new List<IPerformance>();
            foreach (var performance in this.Performances)
            {
                string nameOfPerformance = performance.Name.ToLower();
                
                if (nameOfPerformance.Contains(matchesWord) && performance.StartTime >= dateTime)
                {
                    performancesMatches.Add(performance);
                }
            }

            if (performancesMatches.Count == 0)
            {
                this.Output.AppendLine("no results");
            }
            else
            {
                var orderedPerformanceMatch = performancesMatches
                    .OrderBy(p => p.StartTime)
                    .ThenByDescending(p => p.Tickets.Sum(t => t.Price))
                    .ThenBy(p => p.Name);

                foreach (var performance in orderedPerformanceMatch)
                {
                    this.Output.AppendLine($"-{performance.Name}");
                }
            }

            List<IVenue> venuesMatches = new List<IVenue>();
            foreach (var venue in this.Venues)
            {
                string nameOfVenue = venue.Name.ToLower();
                if (nameOfVenue.Contains(matchesWord))
                {
                    venuesMatches.Add(venue);
                }
            }

            var orderedMatcVenues = venuesMatches.OrderBy(v => v.Name);
            this.Output.AppendLine("Venues:");
            foreach (var venue in orderedMatcVenues)
            {
                this.Output.AppendLine($"-{venue.Name}");
                var performanceOfVenue = this.Performances
                    .Where(p => p.Venue.Name == venue.Name);

                if (performanceOfVenue.Count() > 0 && performancesMatches.Count > 0)
                {
                    var ordered = performanceOfVenue
                        .OrderBy(p => p.StartTime)
                        .ThenByDescending(p => p.Tickets.Sum(t => t.Price))
                        .ThenBy(p => p.Name);

                    foreach (var performance in ordered)
                    {
                        this.Output.AppendLine($"--{performance.Name}");
                    }
                }
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            string venueName = commandWords[5];
            DateTime dateTime = DateTime.Parse(commandWords[6] + " " + commandWords[7]);
            string name = commandWords[3];
            decimal price = decimal.Parse(commandWords[4]);
            var venue = this.GetVenue(venueName);
            switch (commandWords[2])
            {
                case "theatre":
                    var theatre = new Theatre(name, price, venue, dateTime);
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var concert = new Concert(name, price, venue, dateTime);
                    this.Performances.Add(concert);
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            string name = commandWords[3];
            string location = commandWords[4];
            int numberOfSeats = int.Parse(commandWords[5]);

            switch (commandWords[2])
            {
                case "opera":
                    var opera = new Opera(name, location, numberOfSeats);
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(name, location, numberOfSeats);
                    this.Venues.Add(sportsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(name, location, numberOfSeats);
                    this.Venues.Add(concertHall);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            string performanceName = commandWords[1];
            var performance = this.GetPerformance(performanceName);
            var soldTicket = performance.Tickets
                .Where(t => t.Status == TicketStatus.Sold);
       
            var tottalPrice = 0m;
            foreach (var ticket in soldTicket)
            {
                tottalPrice += ticket.Price;
            }


            this.Output.AppendLine($"{performance.Name}: {soldTicket.Count()} ticket(s), total: ${tottalPrice:F2}");
            this.Output.AppendLine($"Venue: {performance.Venue.Name} ({performance.Venue.Location})");
            this.Output.AppendLine($"Start time: {performance.StartTime}");
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;

            }
        }
    }
}