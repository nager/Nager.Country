namespace Nager.Country.Currencies
{
    /// <summary>
    /// Azn Currency
    /// </summary>
    public class AznCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "₼";

        /// <inheritdoc/>
        public string Singular => "manat";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "AZN";

        /// <inheritdoc/>
        public string NumericCode => "944";

        /// <inheritdoc/>
        public string Name => "Azerbaijani manat";
    }
}
