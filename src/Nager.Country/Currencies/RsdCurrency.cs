namespace Nager.Country.Currencies
{
    /// <summary>
    /// Rsd Currency
    /// </summary>
    public sealed class RsdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "дин.";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "RSD";

        /// <inheritdoc/>
        public string NumericCode => "941";

        /// <inheritdoc/>
        public string Name => "Serbian Dinar";
    }
}
