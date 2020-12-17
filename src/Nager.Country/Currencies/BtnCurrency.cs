namespace Nager.Country.Currencies
{
    public class BtnCurrency : ICurrency
    {
        public string Symbol => "Nu.";

        public string Singular => "ngultrum";

        public string Plural => null;

        public string IsoCode => "BTN";

        public string NumericCode => "064";

        public string Name => "Bhutanese ngultrum";
    }
}
