namespace CustomLINQExtensionMethod.Test
{
    using System.Collections.Generic;
    using System.Text;
    using Problem1CustomLINQExtensionMethods;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExtensionMethodTest
    {
        private List<Student> students;

        [TestInitialize]
        public void TestInitialize()
        {
            this.students = new List<Student>();
            students.Add(new Student("Minka", 5.5));
            students.Add(new Student("Pesho", 3.4));
            students.Add(new Student("Miga", 4.5));
        }

        [TestMethod]
        public void Test_WhereNot_ShouldReturnElementsWhereNotSatisfyTheCondition()
        {
            List<int> numbers  = new List<int>() {1, 2, 3, 4, 5, 6, 7};

            var result = numbers.WhereNot(n => n <= 2);

            StringBuilder stringResult = new StringBuilder();
            foreach (var element in result)
            {
                stringResult.Append(element);
            }

            Assert.AreEqual("34567", stringResult.ToString());
        }

        [TestMethod]
        public void Test_WhereNot_ShouldReturnElementsWhereNotSatisfyTheConditionInCollectionOfStudents()
        {
            var result = students.WhereNot(st => st.Name.StartsWith("M"));

            StringBuilder stringResult = new StringBuilder();
            foreach (var element in result)
            {
                stringResult.Append(element);
            }

            Assert.AreEqual("Pesho - 3.4", stringResult.ToString());
        }

        [TestMethod]
        public void Test_MaxElement_ShouldReturnMaxElement()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = numbers.MaxElement(num => num);

            var maxGrade = this.students.MaxElement(st => st.Grades);

            Assert.AreEqual(5.5, maxGrade);
        }
    }
}