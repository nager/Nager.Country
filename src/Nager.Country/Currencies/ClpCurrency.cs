namespace Nager.Country.Currencies
{
    public class ClpCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "peso";

        public string Plural => "peso";

        public string IsoCode => "CLP";

        public string NumericCode => "152";

        public string Name => "Chilean peso";
    }
}
