namespace Contribuite.Entiites
{
      abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Anualincome { get; set; }

        public TaxPayer() {
        }

        protected TaxPayer(string name, double anualincome) {
            Name = name;
            Anualincome = anualincome;
        }

        public abstract double Tax();
    }
}
