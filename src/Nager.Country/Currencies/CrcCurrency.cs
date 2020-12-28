namespace Nager.Country.Currencies
{
    public class CrcCurrency : ICurrency
    {
        public string Symbol => "₡";

        public string Singular => "colón";

        public string Plural => "cólones";

        public string IsoCode => "CRC";

        public string NumericCode => "188";

        public string Name => "Costa Rican colon";
    }
}
