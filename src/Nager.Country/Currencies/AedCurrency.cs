namespace Nager.Country.Currencies
{
    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public sealed class AedCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.إ.‏";

        /// <inheritdoc/>
        public string? Singular => "dirham";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "AED";

        /// <inheritdoc/>
        public string NumericCode => "784";

        /// <inheritdoc/>
        public string Name => "United Arab Emirates dirham";
    }
}
