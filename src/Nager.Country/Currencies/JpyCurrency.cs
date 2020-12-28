namespace Nager.Country.Currencies
{
    public class JpyCurrency : ICurrency
    {
        public string Symbol => "¥";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "JPY";

        public string NumericCode => "392";

        public string Name => "Japanese Yen";
    }
}
