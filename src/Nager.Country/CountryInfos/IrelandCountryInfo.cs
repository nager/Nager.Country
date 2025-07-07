﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ireland
    /// </summary>
    public sealed class IrelandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ireland";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Ireland";

        /// <inheritdoc/>
        public string NativeName => "Éire";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IRL;

        /// <inheritdoc/>
        public int NumericCode => 372;

        /// <inheritdoc/>
        public string[] TLD => [".ie"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.GB,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["353"];
    }
}
