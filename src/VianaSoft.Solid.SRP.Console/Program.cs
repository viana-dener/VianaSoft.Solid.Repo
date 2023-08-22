public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class EmployeeDatabaseRepository
{
    public void SaveToDatabase(Employee employee)
    {
        Console.WriteLine($"Salvando o funcionário {employee.Name} no banco de dados.");
        // Lógica para salvar o funcionário no banco de dados
    }
}

public class SalaryCalculator
{
    public decimal CalculateSalary(Employee employee)
    {
        Console.WriteLine($"Calculando salário para o funcionário {employee.Name}.");
        return employee.Salary * 0.85m;
    }
}

public class EmployeeReportPrinter
{
    public void PrintEmployeeReport(Employee employee)
    {
        Console.WriteLine($"Imprimindo relatório do funcionário {employee.Name}.");
        Console.WriteLine($"Nome: {employee.Name}");
        Console.WriteLine($"Salário: {employee.Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee
        {
            Name = "João",
            Salary = 50000
        };

        var databaseRepository = new EmployeeDatabaseRepository();
        databaseRepository.SaveToDatabase(employee);

        var salaryCalculator = new SalaryCalculator();
        decimal calculatedSalary = salaryCalculator.CalculateSalary(employee);
        Console.WriteLine($"Salário calculado: {calculatedSalary}");

        var reportPrinter = new EmployeeReportPrinter();
        reportPrinter.PrintEmployeeReport(employee);
    }
}