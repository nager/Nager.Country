using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Estonia
    /// </summary>
    public class EstoniaCountryInfo : ICountryInfo
    {
        public string CommonName => "Estonia";
        public string OfficialName => "Republic of Estonia";
        public Alpha2Code Alpha2Code => Alpha2Code.EE;
        public Alpha3Code Alpha3Code => Alpha3Code.EST;
        public int NumericCode => 233;
        public string[] TLD => new [] { ".ee" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "372" };
    }
}
