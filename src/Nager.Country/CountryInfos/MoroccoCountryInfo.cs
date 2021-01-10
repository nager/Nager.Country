using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Morocco
    /// </summary>
    public class MoroccoCountryInfo : ICountryInfo
    {
        public string CommonName => "Morocco";
        public string OfficialName => "Kingdom of Morocco";
        public Alpha2Code Alpha2Code => Alpha2Code.MA;
        public Alpha3Code Alpha3Code => Alpha3Code.MAR;
        public int NumericCode => 504;
        public string[] TLD => new [] { ".ma", "المغرب." };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.EH,
            Alpha2Code.ES,
        };

        public ICurrency[] Currencies => new [] { new MadCurrency() };
        public string[] CallingCodes => new [] { "212" };
    }
}
