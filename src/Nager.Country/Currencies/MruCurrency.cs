namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mru Currency
    /// </summary>
    public sealed class MruCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "UM";

        /// <inheritdoc/>
        public string? Singular => "ouguiya";

        /// <inheritdoc/>
        public string? Plural => "ouguiya";

        /// <inheritdoc/>
        public string IsoCode => "MRU";

        /// <inheritdoc/>
        public string NumericCode => "929";

        /// <inheritdoc/>
        public string Name => "Mauritanian ouguiya";
    }
}
