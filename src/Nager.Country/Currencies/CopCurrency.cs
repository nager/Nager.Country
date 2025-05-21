namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cop Currency
    /// </summary>
    public class CopCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "$";

        /// <inheritdoc/>
        public string Singular => "peso";

        /// <inheritdoc/>
        public string Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "COP";

        /// <inheritdoc/>
        public string NumericCode => "170";

        /// <inheritdoc/>
        public string Name => "Colombian peso";
    }
}
