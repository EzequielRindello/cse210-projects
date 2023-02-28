using System;
class Program
{
    static void Main(string[] args)
    {
        // create different kinds of employees...
        List<Employee> employees = new List<Employee>();
        employees.Add(new HourlyEmployee());
        employees.Add(new SalaryEmployee());

        // get a custom calculation for each one
        foreach (Employee employee in employees)
        {
            employee.DisplayName();
            float pay = employee.CalculatePay();
            Console.WriteLine(pay);
        }
    }

/*     public static void DisplayEmpInfo(Employee employee)
    {
        float pay = employee.CalculatePay();
        Console.WriteLine(pay);
    } */
}