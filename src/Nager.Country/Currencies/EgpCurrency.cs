namespace Nager.Country.Currencies
{
    public class EgpCurrency : ICurrency
    {
        public string Symbol => "ج.م.‏";

        public string Singular => "pound";

        public string Plural => "pound";

        public string IsoCode => "EGP";

        public string NumericCode => "818";

        public string Name => "Egyptian pound";
    }
}
