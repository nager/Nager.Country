namespace Nager.Country.Currencies
{
    public class PenCurrency : ICurrency
    {
        public string Symbol => "S/";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "PEN";

        public string NumericCode => null;

        public string Name => "Peruvian Sol";
    }
}
