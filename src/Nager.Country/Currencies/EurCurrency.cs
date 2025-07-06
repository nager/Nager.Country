namespace Nager.Country.Currencies
{
    /// <summary>
    /// Eur Currency
    /// </summary>
    public sealed class EurCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "€";

        /// <inheritdoc/>
        public string? Singular => "euro";

        /// <inheritdoc/>
        public string? Plural => "euro";

        /// <inheritdoc/>
        public string IsoCode => "EUR";

        /// <inheritdoc/>
        public string NumericCode => "978";

        /// <inheritdoc/>
        public string Name => "Euro";
    }
}
