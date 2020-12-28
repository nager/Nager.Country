namespace Nager.Country.Currencies
{
    public class CnyCurrency : ICurrency
    {
        public string Symbol => "¥";

        public string Singular => "renminbi";

        public string Plural => "renminbi";

        public string IsoCode => "CNY";

        public string NumericCode => "156";

        public string Name => "Renminbi";
    }
}
