namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kwd Currency
    /// </summary>
    public sealed class KwdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ك.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KWD";

        /// <inheritdoc/>
        public string NumericCode => "414";

        /// <inheritdoc/>
        public string Name => "Kuwaiti Dinar";

        private KwdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KwdCurrency();
    }
}
