using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Niue
    /// </summary>
    public class NiueCountryInfo : ICountryInfo
    {
        public string CommonName => "Niue";
        public string OfficialName => "Niue";
        public Alpha2Code Alpha2Code => Alpha2Code.NU;
        public Alpha3Code Alpha3Code => Alpha3Code.NIU;
        public int NumericCode => 570;
        public string[] TLD => new [] { ".nu" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "683" };
    }
}
