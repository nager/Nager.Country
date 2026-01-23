namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gyd Currency
    /// </summary>
    public sealed class GydCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollar";

        /// <inheritdoc/>
        public string IsoCode => "GYD";

        /// <inheritdoc/>
        public string NumericCode => "328";

        /// <inheritdoc/>
        public string Name => "Guyanese dollar";

        private GydCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GydCurrency();
    }
}
