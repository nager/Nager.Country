namespace Nager.Country.Currencies
{
    /// <summary>
    /// Szl Currency
    /// </summary>
    public class SzlCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "L";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SZL";

        /// <inheritdoc/>
        public string NumericCode => "748";

        /// <inheritdoc/>
        public string Name => "Swazi lilangeni";
    }
}
