namespace Nager.Country.Currencies
{
    public class CzkCurrency : ICurrency
    {
        public string Symbol => "Kč";

        public string Singular => "koruna";

        public string Plural => "koruna";

        public string IsoCode => "CZK";

        public string NumericCode => "203";

        public string Name => "Czech koruna";
    }
}
