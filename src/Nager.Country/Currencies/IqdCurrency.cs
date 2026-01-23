namespace Nager.Country.Currencies
{
    /// <summary>
    /// Iqd Currency
    /// </summary>
    public sealed class IqdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ع.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "IQD";

        /// <inheritdoc/>
        public string NumericCode => "368";

        /// <inheritdoc/>
        public string Name => "Iraqi Dinar";

        private IqdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new IqdCurrency();
    }
}
