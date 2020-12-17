namespace Nager.Country.Currencies
{
    public class BgnCurrency : ICurrency
    {
        public string Symbol => "лв.";

        public string Singular => "lev";

        public string Plural => "levove";

        public string IsoCode => "BGN";

        public string NumericCode => "975";

        public string Name => "Bulgarian lev";
    }
}
