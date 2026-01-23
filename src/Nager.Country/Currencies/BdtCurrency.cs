namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bdt Currency
    /// </summary>
    public sealed class BdtCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "৳";

        /// <inheritdoc/>
        public string? Singular => "taka";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BDT";

        /// <inheritdoc/>
        public string NumericCode => "050";

        /// <inheritdoc/>
        public string Name => "Bangladeshi taka";

        private BdtCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BdtCurrency();
    }
}
