namespace Nager.Country.Currencies
{
    /// <summary>
    /// Idr Currency
    /// </summary>
    public class IdrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "Rp";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "IDR";

        /// <inheritdoc/>
        public string NumericCode => "360";

        /// <inheritdoc/>
        public string Name => "Indonesian Rupiah";
    }
}
