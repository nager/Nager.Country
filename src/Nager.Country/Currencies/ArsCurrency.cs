namespace Nager.Country.Currencies
{
    public class ArsCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "ARS";

        public string NumericCode => "032";

        public string Name => "Argentine peso";
    }
}
