namespace Nager.Country.Currencies
{
    /// <summary>
    /// Albanian lek
    /// </summary>
    public sealed class AllCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "L";

        /// <inheritdoc/>
        public string? Singular => "lek";

        /// <inheritdoc/>
        public string? Plural => "leke";

        /// <inheritdoc/>
        public string IsoCode => "ALL";

        /// <inheritdoc/>
        public string NumericCode => "008";

        /// <inheritdoc/>
        public string Name => "Albanian lek";

        private AllCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AllCurrency();
    }
}
