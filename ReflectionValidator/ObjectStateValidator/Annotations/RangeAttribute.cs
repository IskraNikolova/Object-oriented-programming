namespace ObjectStateValidator.Annotations
{   
    public class RangeAttribute : ValidationAttribute
    {
        private int min;

        private int max;

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