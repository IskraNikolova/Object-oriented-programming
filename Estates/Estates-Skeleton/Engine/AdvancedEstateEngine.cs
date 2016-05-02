using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Estates.Models.Offers;

namespace Estates.Engine
{
    using System;
    using System.Linq;
    using Estates.Interfaces;

    public class AdvancedEstateEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            string result = string.Empty;
            if (cmdName == "find-rents-by-location")
            {
                result = this.ExecuteFindRentssByLocationCommand(cmdArgs[0]);
            }
            else if (cmdName == "find-rents-by-price")
            {
                decimal minPrice = decimal.Parse(cmdArgs[0]);
                decimal maxPrice = decimal.Parse(cmdArgs[1]);
                result = this.ExecuteFindRentssByPriceCommand(minPrice, maxPrice);
            }
            else
            {
                result = base.ExecuteCommand(cmdName, cmdArgs);
            }
    
            return result;
        }

        private string ExecuteFindRentssByPriceCommand(decimal minPrice, decimal maxPrice)
        {

            List<IRentOffer> offers = new List<IRentOffer>();
            foreach (var offer in this.Offers)
            {
                if (offer.Type == OfferType.Rent)
                {
                    var castOffer = offer as IRentOffer;
                    if (castOffer != null)
                    {
                        if (castOffer.PricePerMonth >= minPrice && castOffer.PricePerMonth <= maxPrice)
                        {
                            offers.Add(offer as IRentOffer);
                        }
                    }
                }
            }

            var orderedOffers = offers.OrderBy(o => o.PricePerMonth).ThenBy(o => o.Estate.Name);

            return FormatQueryResults(orderedOffers);
        }

        private string ExecuteFindRentssByLocationCommand(string location)
        {
            var offers = this.Offers
              .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
              .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }
    }
}
