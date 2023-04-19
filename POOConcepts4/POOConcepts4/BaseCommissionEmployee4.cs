namespace POOConcepts4
{
    public class BaseCommissionEmployee4 : CommissionEmployee4
    {
        public decimal Base4 { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base4;
        }
        public override string ToString()
        {
            return $" {base.ToString()}" +
                $"\n\tBase 4...............: {$"{Base4:C2}",18}";
        }
    }
}
