using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lebanon
    /// </summary>
    public class LebanonCountryInfo : ICountryInfo
    {
        public string CommonName => "Lebanon";
        public string OfficialName => "Lebanese Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.LB;
        public Alpha3Code Alpha3Code => Alpha3Code.LBN;
        public int NumericCode => 422;
        public string[] TLD => new [] { ".lb" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.SY,
        };

        public ICurrency[] Currencies => new [] { new LbpCurrency() };
        public string[] CallingCodes => new [] { "961" };
    }
}
