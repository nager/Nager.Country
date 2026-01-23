namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mad Currency
    /// </summary>
    public sealed class MadCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.م.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MAD";

        /// <inheritdoc/>
        public string NumericCode => "504";

        /// <inheritdoc/>
        public string Name => "Moroccan Dirham";

        private MadCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MadCurrency();
    }
}
