﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Israel
    /// </summary>
    public sealed class IsraelCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Israel";

        /// <inheritdoc/>
        public string OfficialName => "State of Israel";

        /// <inheritdoc/>
        public string NativeName => "יִשְׂרָאֵל";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IL;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ISR;

        /// <inheritdoc/>
        public int NumericCode => 376;

        /// <inheritdoc/>
        public string[] TLD => [".il"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.EG,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.SY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new IlsCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["972"];
    }
}
