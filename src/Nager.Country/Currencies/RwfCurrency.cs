namespace Nager.Country.Currencies
{
    /// <summary>
    /// Rwf Currency
    /// </summary>
    public sealed class RwfCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "RF";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "RWF";

        /// <inheritdoc/>
        public string NumericCode => "646";

        /// <inheritdoc/>
        public string Name => "Rwandan Franc";

        private RwfCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new RwfCurrency();
    }
}
