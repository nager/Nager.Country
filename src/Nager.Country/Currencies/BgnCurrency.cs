using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bgn Currency
    /// </summary>
    [Obsolete("Bulgaria adopted the euro on 1 January 2026. Use CurrencyProvider.Eur instead.")]
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
    }
}
