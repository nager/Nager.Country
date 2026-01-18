namespace Nager.Country.Currencies
{
    /// <summary>
    /// Myr Currency
    /// </summary>
    public sealed class MyrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "RM";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MYR";

        /// <inheritdoc/>
        public string NumericCode => "458";

        /// <inheritdoc/>
        public string Name => "Malaysian Ringgit";

        private MyrCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MyrCurrency();
    }
}
