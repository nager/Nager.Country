using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United Arab Emirates
    /// </summary>
    public class UnitedArabEmiratesCountryInfo : ICountryInfo
    {
        public string CommonName => "United Arab Emirates";
        public string OfficialName => "United Arab Emirates";
        public Alpha2Code Alpha2Code => Alpha2Code.AE;
        public Alpha3Code Alpha3Code => Alpha3Code.ARE;
        public int NumericCode => 784;
        public string[] TLD => new [] { ".ae", "امارات." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.OM,
            Alpha2Code.SA,
        };

        public ICurrency[] Currencies => new [] { new AedCurrency() };
        public string[] CallingCodes => new [] { "971" };
    }
}
