namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nio Currency
    /// </summary>
    public sealed class NioCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "C$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NIO";

        /// <inheritdoc/>
        public string NumericCode => "558";

        /// <inheritdoc/>
        public string Name => "Nicaraguan Córdoba";
    }
}
