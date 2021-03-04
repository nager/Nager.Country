namespace Nager.Country.Currencies
{
    public class UsdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "USD";

        ///<inheritdoc/>
        public string NumericCode => "840";

        ///<inheritdoc/>
        public string Name => "US Dollar";
    }
}
