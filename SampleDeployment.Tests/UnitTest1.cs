namespace SampleDeployment.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var salaryCalculator = new SalaryCalculator();

            decimal annualSalary = salaryCalculator.CalculateAnnualSalary(50000);

            Assert.Equal(600000, annualSalary);
        }
    }
}
