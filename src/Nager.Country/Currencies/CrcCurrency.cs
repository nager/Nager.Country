namespace Nager.Country.Currencies
{
    /// <summary>
    /// Crc Currency
    /// </summary>
    public sealed class CrcCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₡";

        /// <inheritdoc/>
        public string? Singular => "colón";

        /// <inheritdoc/>
        public string? Plural => "cólones";

        /// <inheritdoc/>
        public string IsoCode => "CRC";

        /// <inheritdoc/>
        public string NumericCode => "188";

        /// <inheritdoc/>
        public string Name => "Costa Rican colon";

        private CrcCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CrcCurrency();
    }
}
