namespace ChallengeApp2024.Tests
{
    public class Tests
    {
        [Test]
        public void EmpoyeesAddGrade()
        {
            // arrenge
            Employee employee = new Employee("Robert", "Kowlskie", 52);
            employee.AddGrade(5);
            employee.AddGrade(6);
            
            // act
            var result = employee.Result;
            
            // asert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void EmpoyeesAddGradeNegativ()
        {
            // arrenge
            Employee employee = new Employee("Karol", "Mowakowski", 40);
            employee.AddGrade(10);
            employee.AddGrade(2);
            employee.AddGrade(-12);

            // act
            var result = employee.Result;

            // asert
            Assert.AreEqual(0, result);
        }
    }
}