using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Vincent and the Grenadines
    /// </summary>
    public class SaintVincentAndTheGrenadinesCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Vincent and the Grenadines";
        public string OfficialName => "Saint Vincent and the Grenadines";
        public Alpha2Code Alpha2Code => Alpha2Code.VC;
        public Alpha3Code Alpha3Code => Alpha3Code.VCT;
        public int NumericCode => 670;
        public string[] TLD => new [] { ".vc" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1784" };
    }
}
