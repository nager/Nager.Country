namespace Nager.Country.Currencies
{
    /// <summary>
    /// Uzs Currency
    /// </summary>
    public class UzsCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "сўм";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "UZS";

        /// <inheritdoc/>
        public string NumericCode => "860";

        /// <inheritdoc/>
        public string Name => "Uzbekistani Som";
    }
}
