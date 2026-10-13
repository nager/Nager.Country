namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zwg Currency
    /// </summary>
    public sealed class ZwgCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ZiG";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ZWG";

        /// <inheritdoc/>
        public string NumericCode => "924";

        /// <inheritdoc/>
        public string Name => "Zimbabwe Gold";
    }
}
