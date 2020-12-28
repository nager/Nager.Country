namespace Nager.Country.Currencies
{
    public class CdfCurrency : ICurrency
    {
        public string Symbol => "FC";

        public string Singular => "franc";

        public string Plural => "francs";

        public string IsoCode => "CDF";

        public string NumericCode => "976";

        public string Name => "Congolese franc";
    }
}
