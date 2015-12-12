
namespace Problem4StudentClass
{
    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(
            object first,
            object second,
            string propName)
        {
            this.First = first;
            this.Second = second;
            this.PropName = propName;
        }

        public object First { get; private set; }

        public object Second { get; private set; }

        public string PropName { get; private set; }
    }
}
