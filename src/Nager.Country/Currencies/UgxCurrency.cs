namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ugx Currency
    /// </summary>
    public sealed class UgxCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "USh";

        /// <inheritdoc/>
        public string? Singular => "shilling";

        /// <inheritdoc/>
        public string? Plural => "shilling";

        /// <inheritdoc/>
        public string IsoCode => "UGX";

        /// <inheritdoc/>
        public string NumericCode => "800";

        /// <inheritdoc/>
        public string Name => "Ugandan shilling";

        private UgxCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new UgxCurrency();
    }
}
