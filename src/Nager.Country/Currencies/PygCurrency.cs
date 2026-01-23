namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pyg Currency
    /// </summary>
    public sealed class PygCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₲";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PYG";

        /// <inheritdoc/>
        public string NumericCode => "600";

        /// <inheritdoc/>
        public string Name => "Paraguayan Guarani";

        private PygCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new PygCurrency();
    }
}
