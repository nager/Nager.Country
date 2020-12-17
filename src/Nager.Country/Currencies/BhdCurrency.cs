namespace Nager.Country.Currencies
{
    public class BhdCurrency : ICurrency
    {
        public string Symbol => ".د.ب";

        public string Singular => "dinar";

        public string Plural => null;

        public string IsoCode => "BHD";

        public string NumericCode => "048";

        public string Name => "Bahraini dinar";
    }
}
