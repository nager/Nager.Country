namespace Nager.Country.Currencies
{
    /// <summary>
    /// Npr Currency
    /// </summary>
    public sealed class NprCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "रु";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NPR";

        /// <inheritdoc/>
        public string NumericCode => "524";

        /// <inheritdoc/>
        public string Name => "Nepalese Rupee";
    }
}
