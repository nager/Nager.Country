using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Std Currency
    /// </summary>
    [Obsolete("Replaced by the new São Tomé and Príncipe dobra (STN) on 1 January 2018. Use CurrencyProvider.Stn instead.")]
    public sealed class StdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Db";

        /// <inheritdoc/>
        public string? Singular => "dobra";

        /// <inheritdoc/>
        public string? Plural => "dobra";

        /// <inheritdoc/>
        public string IsoCode => "STD";

        /// <inheritdoc/>
        public string NumericCode => "678";

        /// <inheritdoc/>
        public string Name => "São Tomé and Príncipe dobra";
    }
}
