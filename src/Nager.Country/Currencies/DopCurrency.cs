namespace Nager.Country.Currencies
{
    public class DopCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "peso";

        public string Plural => "peso";

        public string IsoCode => "DOP";

        public string NumericCode => "214";

        public string Name => "Dominican peso";
    }
}
