using System.Collections;

namespace ObjectStateValidator.Annotations
{
    using System;

    public class ElementsAttribute : ValidationAttribute
    {
        private readonly int maxCount;
        public ElementsAttribute(int maxCount)
        {
            this.maxCount = maxCount;
            this.ErrorMasage = "{0} should have maximum of" + $" {this.maxCount} elements.";
        }

        public int MinCount { get; set; }

        public override bool Validate(object obj)
        {
            if (obj is string)
            {
                string objectAsString = (string)obj;
                if (this.MinCount <= objectAsString.Length &&
                    this.maxCount >= objectAsString.Length)
                {
                    return true;
                }
            }

            if (obj is ICollection)
            {
                var objAsCollection = (ICollection)obj;
                if (this.MinCount <= objAsCollection.Count &&
                  this.maxCount >= objAsCollection.Count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}