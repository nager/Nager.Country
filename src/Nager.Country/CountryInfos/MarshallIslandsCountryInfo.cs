﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Marshall Islands
    /// </summary>
    public sealed class MarshallIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Marshall Islands";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Marshall Islands";

        /// <inheritdoc/>
        public string NativeName => "M̧ajeļ";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MHL;

        /// <inheritdoc/>
        public int NumericCode => 584;

        /// <inheritdoc/>
        public string[] TLD => [".mh"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["692"];
    }
}
