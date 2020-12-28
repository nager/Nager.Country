namespace Nager.Country.Currencies
{
    public class VefCurrency : ICurrency
    {
        public string Symbol => "Bs.S";

        public string Singular => "bolívar soberano";

        public string Plural => null;

        public string IsoCode => "VEF";

        public string NumericCode => "937";

        public string Name => "Venezuelan bolívar fuerte";
    }
}
