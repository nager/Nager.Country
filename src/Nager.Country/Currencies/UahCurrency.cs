namespace Nager.Country.Currencies
{
    /// <summary>
    /// Uah Currency
    /// </summary>
    public sealed class UahCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₴";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "UAH";

        /// <inheritdoc/>
        public string NumericCode => "980";

        /// <inheritdoc/>
        public string Name => "Ukrainian Hryvnia";

        private UahCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new UahCurrency();
    }
}
