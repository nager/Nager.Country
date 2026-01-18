namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kyd Currency
    /// </summary>
    public sealed class KydCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KYD";

        /// <inheritdoc/>
        public string NumericCode => "136";

        /// <inheritdoc/>
        public string Name => "Cayman Islands dollar";

        private KydCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KydCurrency();
    }
}
