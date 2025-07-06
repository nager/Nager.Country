namespace Nager.Country.Currencies
{
    /// <summary>
    /// Khr Currency
    /// </summary>
    public sealed class KhrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "៛";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KHR";

        /// <inheritdoc/>
        public string NumericCode => "116";

        /// <inheritdoc/>
        public string Name => "Cambodian Riel";
    }
}
