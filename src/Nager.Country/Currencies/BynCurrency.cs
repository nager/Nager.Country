namespace Nager.Country.Currencies
{
    /// <summary>
    /// Byn Currency
    /// </summary>
    public class BynCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "Br";

        /// <inheritdoc/>
        public string Singular => "rouble";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BYN";

        /// <inheritdoc/>
        public string NumericCode => "933";

        /// <inheritdoc/>
        public string Name => "Belarusian ruble";
    }
}
