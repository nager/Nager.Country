namespace Nager.Country.Currencies
{
    /// <summary>
    /// Jpy Currency
    /// </summary>
    public sealed class JpyCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "¥";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "JPY";

        /// <inheritdoc/>
        public string NumericCode => "392";

        /// <inheritdoc/>
        public string Name => "Japanese Yen";
    }
}
