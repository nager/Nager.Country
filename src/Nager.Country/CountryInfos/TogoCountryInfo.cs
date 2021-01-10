using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Togo
    /// </summary>
    public class TogoCountryInfo : ICountryInfo
    {
        public string CommonName => "Togo";
        public string OfficialName => "Togolese Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.TG;
        public Alpha3Code Alpha3Code => Alpha3Code.TGO;
        public int NumericCode => 768;
        public string[] TLD => new [] { ".tg" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.BF,
            Alpha2Code.GH,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "228" };
    }
}
