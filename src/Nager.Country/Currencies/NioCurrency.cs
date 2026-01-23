namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nio Currency
    /// </summary>
    public sealed class NioCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "C$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NIO";

        /// <inheritdoc/>
        public string NumericCode => "558";

        /// <inheritdoc/>
        public string Name => "Nicaraguan Córdoba";

        private NioCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new NioCurrency();
    }
}
