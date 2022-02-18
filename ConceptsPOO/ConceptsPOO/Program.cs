
using ConceptsPOO;

Employee Employee1= new SalaryEmployee()
{
    Id = 1048,
    FirstName = "Victor",
    LastName = "Oliveros",
    BirthDate = new Date (1998,4,3),
    HiringDate = new Date (2021,11,2),
    IsActive = true,
    Salary = 1500000
};
Console.WriteLine(Employee1);
Console.WriteLine("================\n");

Employee Employee2= new CommissionEmployee()
{
    Id = 13012001,
    FirstName = "Vanessa",
    LastName = "Uribe",
    BirthDate = new Date (2001,1,13),
    HiringDate = new Date (2021,7,5),
    IsActive = true,
    Sales = 25080000M,
    CommissionPercentaje = 0.04F
};
Console.WriteLine(Employee2);
Console.WriteLine("================\n");

Employee Employee3= new HourlyEmployee()
{
    Id = 98040363,
    FirstName = "Luis",
    LastName = "Ordonez",
    BirthDate = new Date (1987,12,13),
    HiringDate = new Date (2010,3,8),
    IsActive = true,
    Hours = 96,
    HourValue = 12456.9M,
};
Console.WriteLine(Employee3);
Console.WriteLine("================");
