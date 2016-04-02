using System.Collections.Generic;

namespace ObjectStateValidator.Interface
{
    public interface IValidate
    {
        void Validate();

        bool IsValid { get; }

        IDictionary<string, IList<string>> Errors { get; }
    }
}