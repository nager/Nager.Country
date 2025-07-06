namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sos Currency
    /// </summary>
    public sealed class SosCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SRD";

        /// <inheritdoc/>
        public string NumericCode => "968";

        /// <inheritdoc/>
        public string Name => "Surinamese dollar";
    }
}
