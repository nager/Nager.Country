using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zwl Currency
    /// </summary>
    [Obsolete("Replaced by Zimbabwe Gold (ZWG) on 5 April 2024. Use CurrencyProvider.Zwg instead.")]
    public sealed class ZwlCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => null;

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ZWL";

        /// <inheritdoc/>
        public string NumericCode => "932";

        /// <inheritdoc/>
        public string Name => "Zimbabwean dollar";
    }
}
