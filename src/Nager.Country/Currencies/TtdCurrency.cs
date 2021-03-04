namespace Nager.Country.Currencies
{
    public class TtdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "TTD";

        ///<inheritdoc/>
        public string NumericCode => "780";

        ///<inheritdoc/>
        public string Name => "Trinidad and Tobago Dollar";
    }
}
