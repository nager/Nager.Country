namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pen Currency
    /// </summary>
    public sealed class PenCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "S/";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PEN";

        /// <inheritdoc/>
        public string NumericCode => "604";

        /// <inheritdoc/>
        public string Name => "Peruvian Sol";

        private PenCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new PenCurrency();
    }
}
