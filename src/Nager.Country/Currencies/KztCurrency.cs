namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kzt Currency
    /// </summary>
    public class KztCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "₸";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KZT";

        /// <inheritdoc/>
        public string NumericCode => "398";

        /// <inheritdoc/>
        public string Name => "Kazakhstani Tenge";
    }
}
