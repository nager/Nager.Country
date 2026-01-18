namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ars Currency
    /// </summary>
    public sealed class ArsCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "ARS";

        /// <inheritdoc/>
        public string NumericCode => "032";

        /// <inheritdoc/>
        public string Name => "Argentine peso";

        private ArsCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new ArsCurrency();
    }
}
