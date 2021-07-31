using Contribuite.Entiites;

namespace Contribuite.Entiites
{
   class LegalPerson : TaxPayer
    {
        public int NumberofEmployees {get; set;}

        public LegalPerson(){}
        public LegalPerson(string name,double anualinCome,int numberofEmployees) : base (name,anualinCome)
        {
            NumberofEmployees = numberofEmployees;

        }
        public override double Tax()
        {
            if(NumberofEmployees >10)
            {
                return Anualincome  *0.14;
            }
            else
            { return Anualincome  *0.16;}
        }
    }
}