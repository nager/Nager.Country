namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mro Currency
    /// </summary>
    public sealed class MroCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "UM";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MRO";

        /// <inheritdoc/>
        public string NumericCode => "478";

        /// <inheritdoc/>
        public string Name => "	Mauritanian ouguiya";

        private MroCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MroCurrency();
    }
}
