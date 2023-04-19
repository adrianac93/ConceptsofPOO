using POOConcepts4;

Console.WriteLine("POOConcepts4");
Console.WriteLine("============");

Employee4 employee1 = new SalaryEmployee4()
{
    Id = 1010, 
    FirstName = "Sandra",
    LastName = "Morales", 
    BirthDate = new Date4(1990, 5, 23),
    HiringDate = new Date4(2021, 1, 15),
    IsActive = true,
    Salary4 = 2000.45M
};
//Console.WriteLine(employee1);

Employee4 employee2 = new CommissionEmployee4()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date4(1995, 5, 23),
    HiringDate = new Date4(2021, 2, 5),
    IsActive = true,
    Sales = 150000M,
    CommissionPercentaje = 0.04F
};
//Console.WriteLine(employee2);

Employee4 employee3 = new HourlyEmployee4()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date4(1985, 5, 23),
    HiringDate = new Date4(2022, 2, 5),
    IsActive = true,
    HourValue4 = 3000.50M,
    Hours4 = 124.5F
};
//Console.WriteLine(employee3);

Employee4 employee4 = new BaseCommissionEmployee4()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date4(1988, 5, 23),
    HiringDate = new Date4(2022, 1, 5),
    IsActive = true,
    Base4 = 769466.33M,
    Sales = 250000M,
    CommissionPercentaje = 0.016F
};
//Console.WriteLine(employee4);

ICollection<Employee4> employees = new List<Employee4>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee4 employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                         ===================");
Console.WriteLine($"TOTAL                       {$"{payroll:C2}",18}");

Invoice4 invoice1 = new Invoice4()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 3000M,
    Quantity = 6
};
Invoice4 invoice2 = new Invoice4()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 33000M,
    Quantity = 20.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
