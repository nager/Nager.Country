namespace Nager.Country.Currencies
{
    public class SzlCurrency : ICurrency
    {
        public string Symbol => "L";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SZL";

        ///<inheritdoc/>
        public string NumericCode => "748";

        ///<inheritdoc/>
        public string Name => "Swazi lilangeni";
    }
}
