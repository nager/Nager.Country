namespace Nager.Country.Currencies
{
    public class ShpCurrency : ICurrency
    {
        public string Symbol => "£";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "SHP";

        public string NumericCode => "654";

        public string Name => "Saint Helena pound";
    }
}
