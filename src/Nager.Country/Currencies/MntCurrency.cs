namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mnt Currency
    /// </summary>
    public sealed class MntCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₮";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MNT";

        /// <inheritdoc/>
        public string NumericCode => "496";

        /// <inheritdoc/>
        public string Name => "Mongolian Tugrik";

        private MntCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MntCurrency();
    }
}
