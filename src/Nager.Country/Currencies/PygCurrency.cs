namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pyg Currency
    /// </summary>
    public class PygCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "₲";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PYG";

        /// <inheritdoc/>
        public string NumericCode => "600";

        /// <inheritdoc/>
        public string Name => "Paraguayan Guarani";
    }
}
