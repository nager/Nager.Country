namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pkr Currency
    /// </summary>
    public class PkrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "Rs";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PKR";

        /// <inheritdoc/>
        public string NumericCode => "586";

        /// <inheritdoc/>
        public string Name => "Pakistani Rupee";
    }
}
