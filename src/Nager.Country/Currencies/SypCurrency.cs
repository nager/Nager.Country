namespace Nager.Country.Currencies
{
    /// <summary>
    /// Syp Currency
    /// </summary>
    public sealed class SypCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ل.س.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SYP";

        /// <inheritdoc/>
        public string NumericCode => "760";

        /// <inheritdoc/>
        public string Name => "Syrian Pound";

        private SypCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SypCurrency();
    }
}
