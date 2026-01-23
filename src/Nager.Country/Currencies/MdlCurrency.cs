namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mdl Currency
    /// </summary>
    public sealed class MdlCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "L";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MDL";

        /// <inheritdoc/>
        public string NumericCode => "498";

        /// <inheritdoc/>
        public string Name => "Moldovan Leu";

        private MdlCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MdlCurrency();
    }
}
