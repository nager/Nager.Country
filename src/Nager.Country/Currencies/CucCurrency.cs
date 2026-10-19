using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cuc Currency
    /// </summary>
    [Obsolete("Withdrawn on 1 January 2021 as part of the Cuban currency unification. Use CurrencyProvider.Cup instead.")]
    public sealed class CucCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "peso";

        /// <inheritdoc/>
        public string? Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "CUC";

        /// <inheritdoc/>
        public string NumericCode => "931";

        /// <inheritdoc/>
        public string Name => "Cuban convertible peso";
    }
}
