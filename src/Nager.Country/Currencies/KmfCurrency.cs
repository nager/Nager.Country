namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kmf Currency
    /// </summary>
    public sealed class KmfCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "CF";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KMF";

        /// <inheritdoc/>
        public string NumericCode => "174";

        /// <inheritdoc/>
        public string Name => "Comoro franc";

        private KmfCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KmfCurrency();
    }
}
