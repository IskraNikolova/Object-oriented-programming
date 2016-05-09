namespace StudentClassWithEvent
{
    public delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs eventArgs);

    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(object oldValue, object newValue, string propName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.PropName = propName;
        }

        public object OldValue { get; private set; }

        public object NewValue { get; private set; }

        public string PropName { get; private set; }
    }
}
