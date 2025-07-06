namespace Nager.Country.Currencies
{
    /// <summary>
    /// Btn Currency
    /// </summary>
    public sealed class BtnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Nu.";

        /// <inheritdoc/>
        public string? Singular => "ngultrum";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BTN";

        /// <inheritdoc/>
        public string NumericCode => "064";

        /// <inheritdoc/>
        public string Name => "Bhutanese ngultrum";
    }
}
