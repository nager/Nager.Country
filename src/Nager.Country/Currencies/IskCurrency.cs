namespace Nager.Country.Currencies
{
    /// <summary>
    /// Isk Currency
    /// </summary>
    public class IskCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "kr";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ISK";

        /// <inheritdoc/>
        public string NumericCode => "352";

        /// <inheritdoc/>
        public string Name => "Icelandic Króna";
    }
}
