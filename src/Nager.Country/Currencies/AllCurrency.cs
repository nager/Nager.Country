namespace Nager.Country.Currencies
{
    public class AllCurrency : ICurrency
    {
        public string Symbol => "L";

        public string Singular => "lek";

        public string Plural => "leke";

        public string IsoCode => "ALL";

        public string NumericCode => "008";

        public string Name => "Albanian lek";
    }
}
