namespace Nager.Country.Currencies
{
    public class DkkCurrency : ICurrency
    {
        public string Symbol => "kr.";

        public string Singular => "krone";

        public string Plural => "kroner";

        public string IsoCode => "DKK";

        public string NumericCode => "208";

        public string Name => "Danish krone";
    }
}
