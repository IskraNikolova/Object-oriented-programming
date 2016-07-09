namespace Kermen.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Kermen.Interfaces;
    using Kermen.Models;
    using Kermen.Models.Couples;
    using Kermen.Models.Single;

    public class Factory
    {
        public IHome CreateYongCouple(string input)
        {
            var matches = GetMatches(input);
            string[] salaries = matches[0].Groups[2].Value.Split(',');
            decimal tvCoast = decimal.Parse(matches[1].Groups[2].Value);
            decimal fridgeCoasts = decimal.Parse(matches[2].Groups[2].Value);
            decimal laptopCoasts = decimal.Parse(matches[3].Groups[2].Value);

            decimal salary1 = decimal.Parse(salaries[0].Trim());
            decimal salary2 = decimal.Parse(salaries[1].Trim());
            return new YoungCouple(salary1 + salary2, tvCoast, fridgeCoasts, laptopCoasts);
        }

        public IHome CreateYongCoupleWithChildren(string input)
        {
            var matches = GetMatches(input);
            string[] salaries = matches[0].Groups[2].Value.Split(',');
            decimal salary1 = decimal.Parse(salaries[0].Trim());
            decimal salary2 = decimal.Parse(salaries[1].Trim());
            decimal tvCoast = decimal.Parse(matches[1].Groups[2].Value);
            decimal fridgeCoasts = decimal.Parse(matches[2].Groups[2].Value);
            decimal laptopCoasts = decimal.Parse(matches[3].Groups[2].Value);

            List<Child> children = new List<Child>();
            for (int i = 4; i < matches.Count; i++)
            {
                List<string> consumation = matches[i].Groups[2].Value.Split(',').ToList();
                List<decimal> consumationDec = new List<decimal>();
                foreach (var cons in consumation)
                {
                    consumationDec.Add(decimal.Parse(cons.Trim()));
                }

                Child child = new Child(consumationDec);
                children.Add(child);
            }
            
            return new YoungCoupleWithChildren(salary1 + 
                salary2,
                tvCoast,
                fridgeCoasts,
                laptopCoasts,
                children);
        }

        public IHome CreateOldCouple(string input)
        { 
            var matches = GetMatches(input);
            string[] pensions = matches[0].Groups[2].Value.Split(',');
            decimal tvCoast = decimal.Parse(matches[1].Groups[2].Value);
            decimal fridgeCoasts = decimal.Parse(matches[2].Groups[2].Value);
            decimal stoveCoasts = decimal.Parse(matches[3].Groups[2].Value);

            decimal pension1 = decimal.Parse(pensions[0].Trim());
            decimal pension2 = decimal.Parse(pensions[1].Trim());

            return new OldCouple(pension1 + pension2, tvCoast, fridgeCoasts, stoveCoasts);
        }


        public IHome CreateAloneOld(string input)
        {
            var matches = GetMatches(input);
            decimal pension = decimal.Parse(matches[0].Groups[2].Value);

            return new AloneOld(pension);
        }

        public IHome CreateAloneYoung(string input)
        {
            var matches = GetMatches(input);
            decimal salary = decimal.Parse(matches[0].Groups[2].Value);
            decimal laptopCoast = decimal.Parse(matches[1].Groups[2].Value);

            return new AloneYoung(salary, laptopCoast);
        }
        public MatchCollection GetMatches(string input)
        {
            string pattern = @"(\w+)\(([\d\.\s,]+)\)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            return matches;
        }
    }
}
