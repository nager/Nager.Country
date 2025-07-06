namespace Nager.Country.Currencies
{
    /// <summary>
    /// Std Currency
    /// </summary>
    public sealed class StdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Db";

        /// <inheritdoc/>
        public string? Singular => "dobra";

        /// <inheritdoc/>
        public string? Plural => "dobra";

        /// <inheritdoc/>
        public string IsoCode => "STD";

        /// <inheritdoc/>
        public string NumericCode => "678";

        /// <inheritdoc/>
        public string Name => "São Tomé and Príncipe dobra";
    }
}
