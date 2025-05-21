namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bmd Currency
    /// </summary>
    public class BmdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "$";

        /// <inheritdoc/>
        public string Singular => "dollar";

        /// <inheritdoc/>
        public string Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "BMD";

        /// <inheritdoc/>
        public string NumericCode => "060";

        /// <inheritdoc/>
        public string Name => "Bermudian dollar";
    }
}
