namespace Nager.Country.Currencies
{
    public class CopCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "peso";

        public string Plural => "peso";

        public string IsoCode => "COP";

        public string NumericCode => "170";

        public string Name => "Colombian peso";
    }
}
