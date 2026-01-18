namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bbd Currency
    /// </summary>
    public sealed class BbdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "BBD";

        /// <inheritdoc/>
        public string NumericCode => "052";

        /// <inheritdoc/>
        public string Name => "Barbadian dollar";

        private BbdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BbdCurrency();
    }
}
