namespace Nager.Country.Currencies
{
    /// <summary>
    /// Srd Currency
    /// </summary>
    public sealed class SrdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "S";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SOS";

        /// <inheritdoc/>
        public string NumericCode => "706";

        /// <inheritdoc/>
        public string Name => "Somali Shilling";
    }
}
