namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mop Currency
    /// </summary>
    public sealed class MopCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "MOP";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MOP";

        /// <inheritdoc/>
        public string NumericCode => "446";

        /// <inheritdoc/>
        public string Name => "Macanese Pataca";

        private MopCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MopCurrency();
    }
}
