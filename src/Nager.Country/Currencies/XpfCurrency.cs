namespace Nager.Country.Currencies
{
    /// <summary>
    /// Xpf Currency
    /// </summary>
    public sealed class XpfCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "F";

        /// <inheritdoc/>
        public string? Singular => "CFP franc";

        /// <inheritdoc/>
        public string? Plural => "CFP francs";

        /// <inheritdoc/>
        public string IsoCode => "XPF";

        /// <inheritdoc/>
        public string NumericCode => "953";

        /// <inheritdoc/>
        public string Name => "CFP franc";

        private XpfCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new XpfCurrency();
    }
}
