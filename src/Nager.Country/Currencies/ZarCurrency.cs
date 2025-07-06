namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zar Currency
    /// </summary>
    public sealed class ZarCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => null;

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "XPF";

        /// <inheritdoc/>
        public string NumericCode => "953";

        /// <inheritdoc/>
        public string Name => "CFP franc";
    }
}
