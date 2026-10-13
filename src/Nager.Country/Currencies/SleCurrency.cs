namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sle Currency
    /// </summary>
    public sealed class SleCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Le";

        /// <inheritdoc/>
        public string? Singular => "leone";

        /// <inheritdoc/>
        public string? Plural => "leones";

        /// <inheritdoc/>
        public string IsoCode => "SLE";

        /// <inheritdoc/>
        public string NumericCode => "925";

        /// <inheritdoc/>
        public string Name => "Sierra Leonean leone";
    }
}
