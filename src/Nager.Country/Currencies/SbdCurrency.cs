namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sbd Currency
    /// </summary>
    public sealed class SbdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SBD";

        /// <inheritdoc/>
        public string NumericCode => "090";

        /// <inheritdoc/>
        public string Name => "Solomon Islands dollar";

        private SbdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SbdCurrency();
    }
}
