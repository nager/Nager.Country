namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mmk Currency
    /// </summary>
    public sealed class MmkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "K";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MMK";

        /// <inheritdoc/>
        public string NumericCode => "104";

        /// <inheritdoc/>
        public string Name => "Myanmar Kyat";
    }
}
