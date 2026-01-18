namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kpw Currency
    /// </summary>
    public sealed class KpwCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₩";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KPW";

        /// <inheritdoc/>
        public string NumericCode => "408";

        /// <inheritdoc/>
        public string Name => "North Korean won";

        private KpwCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KpwCurrency();
    }
}
