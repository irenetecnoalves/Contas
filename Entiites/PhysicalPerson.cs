using Contribuite.Entiites;

namespace Contribuite.Entiites
{
     class PhysicalPerson : TaxPayer
    {
        public double HealthExpenditures { get; set; }


        public PhysicalPerson(){}

        public PhysicalPerson(string name, double anualinCome,double healthExpenditures): base(name, anualinCome)
        { 
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(Anualincome  < 20.000)
            {
               return Anualincome  * 0.15 - HealthExpenditures * 0.5;
            }
            else
            { return Anualincome  * 0.25 - HealthExpenditures * 0.5; }
        }
    }
}