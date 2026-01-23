namespace Nager.Country.Currencies
{
    /// <summary>
    /// Irr Currency
    /// </summary>
    public sealed class IrrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ريال";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "IRR";

        /// <inheritdoc/>
        public string NumericCode => "364";

        /// <inheritdoc/>
        public string Name => "Iranian Rial";

        private IrrCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new IrrCurrency();
    }
}
