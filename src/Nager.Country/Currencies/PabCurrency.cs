namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pab Currency
    /// </summary>
    public sealed class PabCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "B/.";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PAB";

        /// <inheritdoc/>
        public string NumericCode => "590";

        /// <inheritdoc/>
        public string Name => "Panamanian Balboa";
    }
}
