namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bwp Currency
    /// </summary>
    public sealed class BwpCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "P";

        /// <inheritdoc/>
        public string? Singular => "Pula";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BWP";

        /// <inheritdoc/>
        public string NumericCode => "072";

        /// <inheritdoc/>
        public string Name => "Botswana pula";

        private BwpCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BwpCurrency();
    }
}
