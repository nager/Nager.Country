namespace Nager.Country.Currencies
{
    /// <summary>
    /// Aud Currency
    /// </summary>
    public sealed class AudCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "AUD";

        /// <inheritdoc/>
        public string NumericCode => "036";

        /// <inheritdoc/>
        public string Name => "Australian dollar";

        private AudCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AudCurrency();
    }
}
