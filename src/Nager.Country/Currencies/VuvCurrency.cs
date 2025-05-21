namespace Nager.Country.Currencies
{
    /// <summary>
    /// Vuv Currency
    /// </summary>
    public class VuvCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "VT";

        /// <inheritdoc/>
        public string Singular => "vatu";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "VUV";

        /// <inheritdoc/>
        public string NumericCode => "548";

        /// <inheritdoc/>
        public string Name => "Vanuatu vatu";
    }
}
