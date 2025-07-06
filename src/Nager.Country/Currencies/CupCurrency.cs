namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cup Currency
    /// </summary>
    public sealed class CupCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "peso";

        /// <inheritdoc/>
        public string? Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "CUP";

        /// <inheritdoc/>
        public string NumericCode => "192";

        /// <inheritdoc/>
        public string Name => "Cuban peso";
    }
}
