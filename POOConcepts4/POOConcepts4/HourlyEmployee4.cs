namespace POOConcepts4
{
    public class HourlyEmployee4 : Employee4
    {
        public float Hours4 { get; set; }

        public decimal HourValue4 { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours4 * HourValue4;
        }
        public override string ToString()
        {
            return $" {base.ToString()}" +
                $"\n\tHours4...............: {$"{Hours4:N2}",18}" +
                $"\n\tHour value4..........: {$"{HourValue4:C2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
