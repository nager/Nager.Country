namespace Nager.Country.Currencies
{
    public class SekCurrency : ICurrency
    {
        public string Symbol => "kr";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "SEK";

        public string NumericCode => null;

        public string Name => "Swedish Krona";
    }
}
