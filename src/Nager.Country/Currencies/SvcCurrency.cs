namespace Nager.Country.Currencies
{
    public class SvcCurrency : ICurrency
    {
        public string Symbol => "₡";

        public string Singular => "colón";

        public string Plural => "colón";

        public string IsoCode => "SVC";

        public string NumericCode => "222";

        public string Name => "Salvadoran colón";
    }
}
