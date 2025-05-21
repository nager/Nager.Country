namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kyd Currency
    /// </summary>
    public class KydCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "$";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KYD";

        /// <inheritdoc/>
        public string NumericCode => "136";

        /// <inheritdoc/>
        public string Name => "Cayman Islands dollar";
    }
}
