namespace Nager.Country.Currencies
{
    /// <summary>
    /// Dkk Currency
    /// </summary>
    public class DkkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "kr.";

        /// <inheritdoc/>
        public string Singular => "krone";

        /// <inheritdoc/>
        public string Plural => "kroner";

        /// <inheritdoc/>
        public string IsoCode => "DKK";

        /// <inheritdoc/>
        public string NumericCode => "208";

        /// <inheritdoc/>
        public string Name => "Danish krone";
    }
}
