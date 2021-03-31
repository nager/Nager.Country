namespace Nager.Country.Currencies
{
    public class NgnCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₦";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "NGN";

        ///<inheritdoc/>
        public string NumericCode => "566";

        ///<inheritdoc/>
        public string Name => "Nigerian Naira";
    }
}
