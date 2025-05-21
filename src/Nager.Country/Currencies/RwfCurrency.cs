namespace Nager.Country.Currencies
{
    /// <summary>
    /// Rwf Currency
    /// </summary>
    public class RwfCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "RF";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "RWF";

        /// <inheritdoc/>
        public string NumericCode => "646";

        /// <inheritdoc/>
        public string Name => "Rwandan Franc";
    }
}
