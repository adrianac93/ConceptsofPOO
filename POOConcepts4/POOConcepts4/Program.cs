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
Console.WriteLine(employee1);
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
Console.WriteLine(employee2);
