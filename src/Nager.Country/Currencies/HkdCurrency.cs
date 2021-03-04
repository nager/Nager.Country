namespace Nager.Country.Currencies
{
    public class HkdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "HKD";

        ///<inheritdoc/>
        public string NumericCode => "344";

        ///<inheritdoc/>
        public string Name => "Hong Kong Dollar";
    }
}
