namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kgs Currency
    /// </summary>
    public class KgsCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "сом";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KGS";

        /// <inheritdoc/>
        public string NumericCode => "417";

        /// <inheritdoc/>
        public string Name => "Kyrgystani Som";
    }
}
