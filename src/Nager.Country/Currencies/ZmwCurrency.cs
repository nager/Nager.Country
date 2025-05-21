namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zmw Currency
    /// </summary>
    public class ZmwCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "K";

        /// <inheritdoc/>
        public string Singular => "kwacha";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ZMW";

        /// <inheritdoc/>
        public string NumericCode => "967";

        /// <inheritdoc/>
        public string Name => "Zambian kwacha";
    }
}
