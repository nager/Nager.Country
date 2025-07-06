namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sar Currency
    /// </summary>
    public sealed class SarCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ر.س.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SAR";

        /// <inheritdoc/>
        public string NumericCode => "682";

        /// <inheritdoc/>
        public string Name => "Saudi Riyal";
    }
}
