namespace Nager.Country.Currencies
{
    /// <summary>
    /// Xdr Currency
    /// </summary>
    public sealed class XdrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "XDR";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "XDR";

        /// <inheritdoc/>
        public string NumericCode => "960";

        /// <inheritdoc/>
        public string Name => "Special Drawing Rights";
    }
}
