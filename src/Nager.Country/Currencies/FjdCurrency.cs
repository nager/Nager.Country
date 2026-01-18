namespace Nager.Country.Currencies
{
    /// <summary>
    /// Fjd Currency
    /// </summary>
    public sealed class FjdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "FJ$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollar";

        /// <inheritdoc/>
        public string IsoCode => "FJD";

        /// <inheritdoc/>
        public string NumericCode => "242";

        /// <inheritdoc/>
        public string Name => "Fiji dollar";

        private FjdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new FjdCurrency();
    }
}
