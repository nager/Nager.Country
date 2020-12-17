namespace Nager.Country.Currencies
{
    public class AudCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "AUD";

        public string NumericCode => "036";

        public string Name => "Australian dollar";
    }
}
