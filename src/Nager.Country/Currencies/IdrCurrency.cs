namespace Nager.Country.Currencies
{
    public class IdrCurrency : ICurrency
    {
        public string Symbol => "Rp";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "IDR";

        public string NumericCode => "360";

        public string Name => "Indonesian Rupiah";
    }
}
