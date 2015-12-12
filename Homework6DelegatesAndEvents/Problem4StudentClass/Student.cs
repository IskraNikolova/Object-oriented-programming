
namespace Problem4StudentClass
{
    public class Student
    {
        private string name;
        private int age;

        public delegate void PropertyChangedEventHandler(object objects, PropertyChangedEventArgs args);

        public event PropertyChangedEventHandler OnPropertyChange;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.IsChnaged(this.name, value, "Name");
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.IsChnaged(this.age, value, "Age");
                this.age = value;
            }
        }

        private void IsChnaged(object oldValue, object newValue, string title)
        {
            var onPropCh = this.OnPropertyChange;
            onPropCh?.Invoke(this, new PropertyChangedEventArgs(oldValue, newValue, title));
        }
    }
}

