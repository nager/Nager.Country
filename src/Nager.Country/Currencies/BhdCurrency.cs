namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bhd Currency
    /// </summary>
    public sealed class BhdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ب.‏";

        /// <inheritdoc/>
        public string? Singular => "dinar";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BHD";

        /// <inheritdoc/>
        public string NumericCode => "048";

        /// <inheritdoc/>
        public string Name => "Bahraini dinar";

        private BhdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BhdCurrency();
    }
}
