namespace Nager.Country.Currencies
{
    /// <summary>
    /// Tzs Currency
    /// </summary>
    public class TzsCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "TSh";

        /// <inheritdoc/>
        public string Singular => "shilling";

        /// <inheritdoc/>
        public string Plural => "shilling";

        /// <inheritdoc/>
        public string IsoCode => "TZS";

        /// <inheritdoc/>
        public string NumericCode => "834";

        /// <inheritdoc/>
        public string Name => "Tanzanian shilling";
    }
}
