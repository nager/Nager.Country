namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gmd Currency
    /// </summary>
    public class GmdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "D";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GMD";

        ///<inheritdoc/>
        public string NumericCode => "270";

        ///<inheritdoc/>
        public string Name => "Gambian dalasi";
    }
}
