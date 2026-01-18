namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cny Currency
    /// </summary>
    public sealed class CnyCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "¥";

        /// <inheritdoc/>
        public string? Singular => "renminbi";

        /// <inheritdoc/>
        public string? Plural => "renminbi";

        /// <inheritdoc/>
        public string IsoCode => "CNY";

        /// <inheritdoc/>
        public string NumericCode => "156";

        /// <inheritdoc/>
        public string Name => "Renminbi";

        private CnyCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CnyCurrency();
    }
}
