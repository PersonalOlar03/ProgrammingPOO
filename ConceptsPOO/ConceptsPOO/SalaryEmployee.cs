

namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {

        public Decimal Salary { get; set; }




        public override decimal GetValueToPay()
        {
            return Salary;

        }

        public override string ToString()
        {
            return $"{base.ToString()} \nValue to Pay: {$"{GetValueToPay():C2}", 15}";
            
        }
        
    }

}