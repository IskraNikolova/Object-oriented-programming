using System;

namespace StudentClassWithEvent
{
    public class Program
    {
        public static void Main()
        {
            Student st = new Student("Mariq", 23);
            st.OnChange += St_OnChange;
            st.Name = "Katq";
            st.Age = 51;
        }

        private static void St_OnChange(Student student, PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine($"Property changed: {eventArgs.PropName} (from {eventArgs.OldValue} to {eventArgs.NewValue})");
        }
    }
}
