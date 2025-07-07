﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Macau
    /// </summary>
    public sealed class MacauCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Macau";

        /// <inheritdoc/>
        public string OfficialName => "Macao Special Administrative Region of the People's Republic of China";

        /// <inheritdoc/>
        public string NativeName => "澳門";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MAC;

        /// <inheritdoc/>
        public int NumericCode => 446;

        /// <inheritdoc/>
        public string[] TLD => [".mo"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new MopCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["853"];
    }
}
