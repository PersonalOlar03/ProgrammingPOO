namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {

        public float CommissionPercentaje { get; set; }

        public Decimal Sales { get; set; }



        public override decimal GetValueToPay()
        {
            return Sales * (Decimal)CommissionPercentaje;

        }

        public override string ToString()
        {
            return $"{base.ToString()} \n"+
                    $"Sales: {Sales:C2} \n" +
                    $"Percentaje: {$"{CommissionPercentaje:P}", 15}\n"+
                    $"Value To Pay: {$"{GetValueToPay():C2}", 15}";
        }

    }

}