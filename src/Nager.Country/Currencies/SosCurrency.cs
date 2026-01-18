namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sos Currency
    /// </summary>
    public sealed class SosCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SRD";

        /// <inheritdoc/>
        public string NumericCode => "968";

        /// <inheritdoc/>
        public string Name => "Surinamese dollar";

        private SosCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SosCurrency();
    }
}
