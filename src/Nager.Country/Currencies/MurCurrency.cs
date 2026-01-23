namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mur Currency
    /// </summary>
    public sealed class MurCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₨";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MUR";

        /// <inheritdoc/>
        public string NumericCode => "480";

        /// <inheritdoc/>
        public string Name => "Mauritian rupee";

        private MurCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MurCurrency();
    }
}
