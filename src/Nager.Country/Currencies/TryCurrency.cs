namespace Nager.Country.Currencies
{
    /// <summary>
    /// Try Currency
    /// </summary>
    public class TryCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "₺";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TRY";

        /// <inheritdoc/>
        public string NumericCode => "949";

        /// <inheritdoc/>
        public string Name => "Turkish Lira";
    }
}
