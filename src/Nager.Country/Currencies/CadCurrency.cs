namespace Nager.Country.Currencies
{
    public class CadCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "CAD";

        public string NumericCode => "124";

        public string Name => "Canadian dollar";
    }
}
