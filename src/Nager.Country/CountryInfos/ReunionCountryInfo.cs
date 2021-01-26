using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Réunion
    /// </summary>
    public class ReunionCountryInfo : ICountryInfo
    {
        public string CommonName => "Réunion";
        public string OfficialName => "Réunion Island";
        public Alpha2Code Alpha2Code => Alpha2Code.RE;
        public Alpha3Code Alpha3Code => Alpha3Code.REU;
        public int NumericCode => 638;
        public string[] TLD => new [] { ".re" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "262" };
    }
}
