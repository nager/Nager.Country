namespace Nager.Country.Currencies
{
    /// <summary>
    /// Egp Currency
    /// </summary>
    public sealed class EgpCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ج.م.‏";

        /// <inheritdoc/>
        public string? Singular => "pound";

        /// <inheritdoc/>
        public string? Plural => "pound";

        /// <inheritdoc/>
        public string IsoCode => "EGP";

        /// <inheritdoc/>
        public string NumericCode => "818";

        /// <inheritdoc/>
        public string Name => "Egyptian pound";

        private EgpCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new EgpCurrency();
    }
}
