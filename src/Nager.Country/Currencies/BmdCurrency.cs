namespace Nager.Country.Currencies
{
    public class BmdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "BMD";

        public string NumericCode => "060";

        public string Name => "Bermudian dollar";
    }
}
