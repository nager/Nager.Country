﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Laos
    /// </summary>
    public sealed class LaosCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Laos";

        /// <inheritdoc/>
        public string OfficialName => "Lao People's Democratic Republic";

        /// <inheritdoc/>
        public string NativeName => "ສປປລາວ";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LAO;

        /// <inheritdoc/>
        public int NumericCode => 418;

        /// <inheritdoc/>
        public string[] TLD => [".la"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.MM,
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.TH,
            Alpha2Code.VN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new LakCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["856"];
    }
}
