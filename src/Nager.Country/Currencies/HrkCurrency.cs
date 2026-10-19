using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Hrk Currency
    /// </summary>
    [Obsolete("Croatia adopted the euro on 1 January 2023. Use CurrencyProvider.Eur instead.")]
    public sealed class HrkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "kn";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "HRK";

        /// <inheritdoc/>
        public string NumericCode => "191";

        /// <inheritdoc/>
        public string Name => "Croatian Kuna";
    }
}
