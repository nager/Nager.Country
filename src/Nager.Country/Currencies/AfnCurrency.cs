namespace Nager.Country.Currencies
{
    /// <summary>
    /// Afghan afghani
    /// </summary>
    public sealed class AfnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "؋";

        /// <inheritdoc/>
        public string? Singular => "Af";

        /// <inheritdoc/>
        public string? Plural => "Afs";

        /// <inheritdoc/>
        public string IsoCode => "AFN";

        /// <inheritdoc/>
        public string NumericCode => "971";

        /// <inheritdoc/>
        public string Name => "Afghan afghani";

        private AfnCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AfnCurrency();
    }
}
