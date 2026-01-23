namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kes Currency
    /// </summary>
    public sealed class KesCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Ksh";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KES";

        /// <inheritdoc/>
        public string NumericCode => "404";

        /// <inheritdoc/>
        public string Name => "Kenyan Shilling";

        private KesCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KesCurrency();
    }
}
