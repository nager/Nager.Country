namespace Nager.Country.Currencies
{
    public class BbdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "BBD";

        public string NumericCode => "052";

        public string Name => "Barbadian dollar";
    }
}
