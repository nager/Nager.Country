namespace Nager.Country.Currencies
{
    /// <summary>
    /// Tjs Currency
    /// </summary>
    public sealed class TjsCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "смн";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TJS";

        /// <inheritdoc/>
        public string NumericCode => "972";

        /// <inheritdoc/>
        public string Name => "Tajikistani Somoni";

        private TjsCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TjsCurrency();
    }
}
