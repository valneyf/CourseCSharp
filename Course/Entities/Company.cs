namespace Course.Entities
{
    class Company : Person
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;

            if (NumberOfEmployees > 10)
            {
                tax = 0.14;
            }
            else
            {
                tax = 0.16;
            }

            return AnnualIncome * tax;
        }
    }
}
