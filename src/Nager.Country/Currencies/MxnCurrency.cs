namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mxn Currency
    /// </summary>
    public class MxnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "$";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MXN";

        /// <inheritdoc/>
        public string NumericCode => "484";

        /// <inheritdoc/>
        public string Name => "Mexican Peso";
    }
}
