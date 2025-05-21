namespace Nager.Country.Currencies
{
    /// <summary>
    /// Scr Currency
    /// </summary>
    public class ScrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "SCR";

        /// <inheritdoc/>
        public string Singular => "rupee";

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SCR";

        /// <inheritdoc/>
        public string NumericCode => "690";

        /// <inheritdoc/>
        public string Name => "Seychelles rupee";
    }
}
