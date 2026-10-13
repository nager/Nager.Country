namespace Nager.Country.Currencies
{
    /// <summary>
    /// Stn Currency
    /// </summary>
    public sealed class StnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Db";

        /// <inheritdoc/>
        public string? Singular => "dobra";

        /// <inheritdoc/>
        public string? Plural => "dobras";

        /// <inheritdoc/>
        public string IsoCode => "STN";

        /// <inheritdoc/>
        public string NumericCode => "930";

        /// <inheritdoc/>
        public string Name => "São Tomé and Príncipe dobra";
    }
}
