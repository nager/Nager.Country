namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ern Currency
    /// </summary>
    public sealed class ErnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Nfk";

        /// <inheritdoc/>
        public string? Singular => "nakfa";

        /// <inheritdoc/>
        public string? Plural => "nakfa";

        /// <inheritdoc/>
        public string IsoCode => "ERN";

        /// <inheritdoc/>
        public string NumericCode => "232";

        /// <inheritdoc/>
        public string Name => "Eritrean nakfa";
    }
}
