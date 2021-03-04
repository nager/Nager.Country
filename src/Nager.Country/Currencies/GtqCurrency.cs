namespace Nager.Country.Currencies
{
    public class GtqCurrency : ICurrency
    {
        public string Symbol => "Q";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GTQ";

        ///<inheritdoc/>
        public string NumericCode => "320";

        ///<inheritdoc/>
        public string Name => "Guatemalan Quetzal";
    }
}
