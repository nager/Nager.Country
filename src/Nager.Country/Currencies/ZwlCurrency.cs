namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zwl Currency
    /// </summary>
    public sealed class ZwlCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => null;

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ZWL";

        /// <inheritdoc/>
        public string NumericCode => "932";

        /// <inheritdoc/>
        public string Name => "Zimbabwean dollar";

        private ZwlCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new ZwlCurrency();
    }
}
