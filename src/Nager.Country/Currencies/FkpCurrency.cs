namespace Nager.Country.Currencies
{
    public class FkpCurrency : ICurrency
    {
        public string Symbol => "£";

        public string Singular => "pound";

        public string Plural => "pence";

        public string IsoCode => "FKP";

        public string NumericCode => "238";

        public string Name => "Falkland Islands pound";
    }
}
