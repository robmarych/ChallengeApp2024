namespace ChallengeApp2024.Tests
{
    public class TypeTests
    {
        [Test]
        public void ReferenceTypes()
        {
            // arrange
            Employee employee1 = new Employee("Robert", "Kowlskie", 52);
            Employee employee2 = new Employee("Robert", "Kowlskie", 52);
            //Employee employee2 = new Employee("Karol", "Mowakowski", 40);

            // act


            // assert

            //Assert.AreEqual(employee1.Name, employee2.Name); 
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void ValueTypes()
        {
            // arrange
            int number1 = 5;          
            int number2 = 5;    

            // act
            // assert

            //Assert.AreEqual(employee1.Name, employee2.Name); 
            Assert.AreEqual(number1 , number2 );
        }


        private Employee GetEmployee(string name, string surname, int age)
        {
            return  new Employee(name, surname, age);
        }
    }
}
