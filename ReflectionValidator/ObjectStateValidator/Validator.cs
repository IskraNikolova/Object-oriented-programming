namespace ObjectStateValidator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using ObjectStateValidator.Annotations;
    using ObjectStateValidator.Interface;

    public class Validator : IValidate
    {
        private readonly object validatableObject;
        private bool objectValidated;

        public Validator(object validatableObject)
        {
            if (validatableObject == null)
            {
                throw new ArgumentNullException("Invalid object - it is null.");
            }

            this.validatableObject = validatableObject;
            this.Errors = new Dictionary<string, IList<string>>();
        }

        public void Validate()
        {
            this.objectValidated = true;
            this.Validate(this.validatableObject, string.Empty);
        }

        public bool IsValid
        {
            get
            {
                if (!this.objectValidated)
                {
                    throw new InvalidOperationException("You must invoke the Validate() method first.");
                }

                return this.Errors.Count == 0;
            }
        }

        public IDictionary<string, IList<string>> Errors { get; }

        private void Validate(object obj, string name)
        {
            if (obj == null)
            {
                return;
            }

            var type = obj.GetType();
            foreach (var property in type.GetProperties())
            {
                var propertyName = property.Name;
                var nestedPropertyName = name + propertyName;
                var valueToValidate = property.GetValue(obj);
                var validationAttributes = property.GetCustomAttributes(typeof(ValidationAttribute), true);
                foreach (var validationAttribute in validationAttributes)
                {                   
                    var attrAsValidationAttr = ((ValidationAttribute) validationAttribute);
                    var validationResult = attrAsValidationAttr
                        .Validate(valueToValidate);
                    if (!validationResult)
                    {
                        var errorMsg = attrAsValidationAttr.ErrorMasage;
                        this.AddError(nestedPropertyName, string.Format(errorMsg, nestedPropertyName));
                    }
                }

                if (valueToValidate != null && 
                    !(valueToValidate is ICollection)  && 
                    !(valueToValidate is string) && 
                    !property.PropertyType.IsPrimitive)
                {
                    this.Validate(valueToValidate, nestedPropertyName + ".");
                }
            }
        }

        private void AddError(string name, string error)
        {
            if (!this.Errors.ContainsKey(name))
            {
                this.Errors.Add(name, new List<string>());
            }

            this.Errors[name].Add(error);
        }
    }
}