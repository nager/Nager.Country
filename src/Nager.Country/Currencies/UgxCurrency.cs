namespace Nager.Country.Currencies
{
    public class UgxCurrency : ICurrency
    {
        public string Symbol => "USh";

        public string Singular => "shilling";

        public string Plural => "shilling";

        public string IsoCode => "UGX";

        public string NumericCode => "800";

        public string Name => "Ugandan shilling";
    }
}
