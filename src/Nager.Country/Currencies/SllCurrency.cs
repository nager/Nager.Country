using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sll Currency
    /// </summary>
    [Obsolete("Replaced by the new Sierra Leonean leone (SLE) on 1 July 2022. Use CurrencyProvider.Sle instead.")]
    public sealed class SllCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Le";

        /// <inheritdoc/>
        public string? Singular => "leone";

        /// <inheritdoc/>
        public string? Plural => "leones";

        /// <inheritdoc/>
        public string IsoCode => "SLL";

        /// <inheritdoc/>
        public string NumericCode => "694";

        /// <inheritdoc/>
        public string Name => "Sierra Leonean leone";
    }
}
