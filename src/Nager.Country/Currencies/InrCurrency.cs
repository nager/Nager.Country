namespace Nager.Country.Currencies
{
    /// <summary>
    /// Inr Currency
    /// </summary>
    public sealed class InrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₹";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "INR";

        /// <inheritdoc/>
        public string NumericCode => "356";

        /// <inheritdoc/>
        public string Name => "Indian Rupee";
    }
}
