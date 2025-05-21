namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nad Currency
    /// </summary>
    public class NadCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "$";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NAD";

        /// <inheritdoc/>
        public string NumericCode => "516";

        /// <inheritdoc/>
        public string Name => "Namibian dollar";
    }
}
