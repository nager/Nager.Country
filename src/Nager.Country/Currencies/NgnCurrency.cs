namespace Nager.Country.Currencies
{
    public class NgnCurrency : ICurrency
    {
        public string Symbol => "₦";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "NGN";

        public string NumericCode => "566";

        public string Name => "Nigerian Naira";
    }
}
