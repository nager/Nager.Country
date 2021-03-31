namespace Nager.Country.Currencies
{
    public class NzdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "NZD";

        ///<inheritdoc/>
        public string NumericCode => "554";

        ///<inheritdoc/>
        public string Name => "New Zealand Dollar";
    }
}
