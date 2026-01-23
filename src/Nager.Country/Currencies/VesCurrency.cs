namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ves Currency
    /// </summary>
    public sealed class VesCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Bs.S";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "VES";

        /// <inheritdoc/>
        public string NumericCode => "928";

        /// <inheritdoc/>
        public string Name => "Venezuelan Bolívar";

        private VesCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new VesCurrency();
    }
}
