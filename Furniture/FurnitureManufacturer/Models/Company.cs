using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name of company cannot be empty, null");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("Name of company cannot be with less than 5 symbols.");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (!ValidationRegistrationNumber(value))
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures { get; }

        private bool ValidationRegistrationNumber(string registrationNumber)
        {
            bool result = true;
            for (int i = 0; i < registrationNumber.Length; i++)
            {
                if (!char.IsDigit(registrationNumber[i]))
                {
                    result = false;
                }
            }

            if (registrationNumber.Length != 10)
            {
                result = false;
            }

            return result;
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(f => f.Model == model);
        }

        public string Catalog()
        {
            StringBuilder builder = new StringBuilder();
            string appendString = string.Format("{0} - {1} - {2} {3}",
                        this.Name,
                        this.RegistrationNumber,
                        this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                        this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            builder.Append(appendString);
            var orderedFurnitured = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            foreach (var furniture in orderedFurnitured)
            {
                builder.Append("\n" + furniture);
            }

            return builder.ToString();
        }
    }
}
