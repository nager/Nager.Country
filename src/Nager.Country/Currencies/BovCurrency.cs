namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bov Currency
    /// </summary>
    public sealed class BovCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => null;

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BOV";

        /// <inheritdoc/>
        public string NumericCode => "984";

        /// <inheritdoc/>
        public string Name => "Bolivian Mvdol (funds code)";

        private BovCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BovCurrency();
    }
}
