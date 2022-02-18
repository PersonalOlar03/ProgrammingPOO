

namespace ConceptsPOO;

public abstract class Employee
{
    public Date? BirthDate { get; set; }

    public String? FirstName { get; set; }

    public Date? HiringDate { get; set; }

    public int Id { get; set; }

    public Boolean IsActive { get; set; }

    public String? LastName { get; set; }


    public abstract decimal GetValueToPay();

    public override string ToString()
    {
        return $"Id: {Id}\n" +
        $"Name: {FirstName} {LastName}\n" +
        $"Birth: {BirthDate} \n" +
        $"Hiring {HiringDate} \n" +
        $"Is Active: {IsActive}";
    }

}
