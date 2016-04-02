namespace ObjectStateValidator.Annotations
{
    using System;

    public abstract class ValidationAttribute : Attribute
    {
        public string ErrorMasage { get; set; }

        public abstract bool Validate(object obj);
    }
}
