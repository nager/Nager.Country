namespace Nager.Country.Currencies
{
    /// <summary>
    /// Xcg Currency
    /// </summary>
    public sealed class XcgCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Cg";

        /// <inheritdoc/>
        public string? Singular => "guilder";

        /// <inheritdoc/>
        public string? Plural => "guilders";

        /// <inheritdoc/>
        public string IsoCode => "XCG";

        /// <inheritdoc/>
        public string NumericCode => "532";

        /// <inheritdoc/>
        public string Name => "Caribbean guilder";
    }
}
