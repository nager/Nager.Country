using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public class SaintPierreAndMiquelonCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Pierre and Miquelon";
        public string OfficialName => "Saint Pierre and Miquelon";
        public Alpha2Code Alpha2Code => Alpha2Code.PM;
        public Alpha3Code Alpha3Code => Alpha3Code.SPM;
        public int NumericCode => 666;
        public string[] TLD => new [] { ".pm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "508" };
    }
}
