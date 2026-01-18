namespace Nager.Country.Currencies
{
    /// <summary>
    /// Idr Currency
    /// </summary>
    public sealed class IdrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Rp";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "IDR";

        /// <inheritdoc/>
        public string NumericCode => "360";

        /// <inheritdoc/>
        public string Name => "Indonesian Rupiah";

        private IdrCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new IdrCurrency();
    }
}
