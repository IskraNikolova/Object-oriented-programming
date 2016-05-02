using Estates.Models.Estate;
using Estates.Models.Estate.Building;
using Estates.Models.Offers;

namespace Estates.Data
{

    using System;
    using Estates.Models;
    using Estates.Engine;
    using Estates.Interfaces;

    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new AdvancedEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            Estate estate;
            switch (type)
            {
                   case EstateType.Apartment:
                    estate =  new Apartment(); 
                    break;
                    case EstateType.Garage:
                    estate = new Garage();
                    break;
                    case EstateType.House:
                    estate =  new House();
                    break;
                    case EstateType.Office:
                    estate = new Office();
                    break;
                default:
                    throw new ArgumentException("Invalid type for estste.");
            }

            return estate;
        }

        public static IOffer CreateOffer(OfferType type)
        {
            Offer offer;
            switch (type)
            {
                    case OfferType.Rent:
                    offer = new RentOffer();
                    break;
                    case OfferType.Sale:
                    offer = new SaleOffer();
                    break;
                default:
                    throw new ArgumentException("Invalid type for offer.");
            }

            return offer;
        }
    }
}
