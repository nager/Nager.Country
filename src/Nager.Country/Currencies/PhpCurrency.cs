namespace Nager.Country.Currencies
{
    public class PhpCurrency : ICurrency
    {
        public string Symbol => "₱";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "PHP";

        public string NumericCode => "608";

        public string Name => "Philippine Piso";
    }
}
