using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mro Currency
    /// </summary>
    [Obsolete("Replaced by the Mauritanian ouguiya (MRU) on 1 January 2018. Use CurrencyProvider.Mru instead.")]
    public sealed class MroCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "UM";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MRO";

        /// <inheritdoc/>
        public string NumericCode => "478";

        /// <inheritdoc/>
        public string Name => "Mauritanian ouguiya";
    }
}
