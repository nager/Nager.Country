namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bob Currency
    /// </summary>
    public class BobCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "Bs";

        /// <inheritdoc/>
        public string Singular => "boliviano";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BOB";

        /// <inheritdoc/>
        public string NumericCode => "068";

        /// <inheritdoc/>
        public string Name => "Bolivian boliviano";
    }
}
