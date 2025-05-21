namespace Nager.Country.Currencies
{
    /// <summary>
    /// Rub Currency
    /// </summary>
    public class RubCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "₽";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "RUB";

        /// <inheritdoc/>
        public string NumericCode => "643";

        /// <inheritdoc/>
        public string Name => "Russian Ruble";
    }
}
