﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Peru
    /// </summary>
    public sealed class PeruCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Peru";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Peru";

        /// <inheritdoc/>
        public string NativeName => "Perú";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PER;

        /// <inheritdoc/>
        public int NumericCode => 604;

        /// <inheritdoc/>
        public string[] TLD => [".pe"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.CO,
            Alpha2Code.EC,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new PenCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["51"];
    }
}
