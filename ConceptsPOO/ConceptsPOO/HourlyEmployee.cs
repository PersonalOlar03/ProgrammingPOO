namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public Decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return HourValue * (Decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                    $"Working Hours:    {$"{Hours:N2}",15}\n" +
                    $"Hour Value:       {$"{HourValue:C2}",15}\n" +
                    $"Value To Pay:     {$"{GetValueToPay():C2}",15}";
        }
    }


}