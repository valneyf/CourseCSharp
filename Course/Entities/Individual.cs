namespace Course.Entities
{
    class Individual : Person
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;

            if (AnnualIncome < 20000.00)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.25;
            }

            return (AnnualIncome * tax) - (HealthExpenditures * 0.5);
        }
    }
}
