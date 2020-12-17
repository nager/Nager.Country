namespace Nager.Country.Currencies
{
    public class BdtCurrency : ICurrency
    {
        public string Symbol => "৳";

        public string Singular => "taka";

        public string Plural => null;

        public string IsoCode => "BDT";

        public string NumericCode => "050";

        public string Name => "Bangladeshi taka";
    }
}
