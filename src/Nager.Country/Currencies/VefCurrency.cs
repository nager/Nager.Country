using System;

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Vef Currency
    /// </summary>
    [Obsolete("Replaced by the Venezuelan bolívar soberano (VES) on 20 August 2018. Use CurrencyProvider.Ves instead.")]
    public sealed class VefCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Bs.F";

        /// <inheritdoc/>
        public string? Singular => "bolívar fuerte";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "VEF";

        /// <inheritdoc/>
        public string NumericCode => "937";

        /// <inheritdoc/>
        public string Name => "Venezuelan bolívar fuerte";
    }
}
