namespace Nager.Country.Currencies
{
    /// <summary>
    /// Rub Currency
    /// </summary>
    public sealed class RubCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₽";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "RUB";

        /// <inheritdoc/>
        public string NumericCode => "643";

        /// <inheritdoc/>
        public string Name => "Russian Ruble";

        private RubCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new RubCurrency();
    }
}
