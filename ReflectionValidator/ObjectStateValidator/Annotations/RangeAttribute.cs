namespace ObjectStateValidator.Annotations
{   
    public class RangeAttribute : ValidationAttribute
    {
        private readonly int min;
        private readonly int max;

        public RangeAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.ErrorMasage = "{0} should be between" + $" [{this.min}...{this.max}].";
        }

        public override bool Validate(object obj)
        {
            if (obj is int)
            {
                var objAsInt = (int)obj;
                if (min <= objAsInt && objAsInt <= max)
                {
                    return true;
                }
            }
   
            return false;
        }
    }
}