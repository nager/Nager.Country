namespace Nager.Country.Currencies
{
    /// <summary>
    /// Jod Currency
    /// </summary>
    public class JodCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "د.ا.‏";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "JOD";

        /// <inheritdoc/>
        public string NumericCode => "400";

        /// <inheritdoc/>
        public string Name => "Jordanian Dinar";
    }
}
