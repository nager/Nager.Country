namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gtq Currency
    /// </summary>
    public class GtqCurrency : ICurrency
    {
        ///<inheritdoc/>
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
