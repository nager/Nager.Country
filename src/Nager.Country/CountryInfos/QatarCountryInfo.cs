using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Qatar
    /// </summary>
    public class QatarCountryInfo : ICountryInfo
    {
        public string CommonName => "Qatar";
        public string OfficialName => "State of Qatar";
        public Alpha2Code Alpha2Code => Alpha2Code.QA;
        public Alpha3Code Alpha3Code => Alpha3Code.QAT;
        public int NumericCode => 634;
        public string[] TLD => new [] { ".qa", "قطر." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SA,
        };

        public ICurrency[] Currencies => new [] { new QarCurrency() };
        public string[] CallingCodes => new [] { "974" };
    }
}
