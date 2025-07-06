namespace Nager.Country.Currencies
{
    /// <summary>
    /// Vnd Currency
    /// </summary>
    public sealed class VndCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₫";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "VND";

        /// <inheritdoc/>
        public string NumericCode => "704";

        /// <inheritdoc/>
        public string Name => "Vietnamese Dong";
    }
}
