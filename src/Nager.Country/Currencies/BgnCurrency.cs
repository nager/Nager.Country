using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bgn Currency
    /// </summary>
    [Obsolete("Replaced with ECurrency. Use EurCurrency instead.")]
    public sealed class BgnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "лв.";

        /// <inheritdoc/>
        public string? Singular => "lev";

        /// <inheritdoc/>
        public string? Plural => "levove";

        /// <inheritdoc/>
        public string IsoCode => "BGN";

        /// <inheritdoc/>
        public string NumericCode => "975";

        /// <inheritdoc/>
        public string Name => "Bulgarian lev";

        private BgnCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BgnCurrency();
    }
}
