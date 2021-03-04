using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public class SaintPierreAndMiquelonCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Saint Pierre and Miquelon";
        ///<inheritdoc/>
        public string OfficialName => "Saint Pierre and Miquelon";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SPM;
        ///<inheritdoc/>
        public int NumericCode => 666;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".pm" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "508" };
    }
}
