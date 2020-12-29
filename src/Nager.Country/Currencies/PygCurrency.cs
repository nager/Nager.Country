namespace Nager.Country.Currencies
{
    public class PygCurrency : ICurrency
    {
        public string Symbol => "₲";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "PYG";

        public string NumericCode => "600";

        public string Name => "Paraguayan Guarani";
    }
}
