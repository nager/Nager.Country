namespace Nager.Country.Currencies
{
    /// <summary>
    /// Xaf Currency
    /// </summary>
    public sealed class XafCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "FCFA";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "XAF";

        /// <inheritdoc/>
        public string NumericCode => "950";

        /// <inheritdoc/>
        public string Name => "Central African CFA Franc";
    }
}
