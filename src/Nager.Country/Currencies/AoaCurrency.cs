namespace Nager.Country.Currencies
{
    /// <summary>
    /// Aoa Currency
    /// </summary>
    public sealed class AoaCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Kz";

        /// <inheritdoc/>
        public string? Singular => "kwanza";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "AOA";

        /// <inheritdoc/>
        public string NumericCode => "973";

        /// <inheritdoc/>
        public string Name => "Angolan kwanza";

        private AoaCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AoaCurrency();
    }
}
