namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lkr Currency
    /// </summary>
    public sealed class LkrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "රු.";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "LKR";

        /// <inheritdoc/>
        public string NumericCode => "144";

        /// <inheritdoc/>
        public string Name => "Sri Lankan Rupee";
    }
}
