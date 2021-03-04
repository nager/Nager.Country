namespace Nager.Country.Currencies
{
    public class ThbCurrency : ICurrency
    {
        public string Symbol => "฿";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "THB";

        ///<inheritdoc/>
        public string NumericCode => "764";

        ///<inheritdoc/>
        public string Name => "Thai Baht";
    }
}
