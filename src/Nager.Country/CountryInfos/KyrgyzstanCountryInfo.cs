using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    public class KyrgyzstanCountryInfo : ICountryInfo
    {
        public string CommonName => "Kyrgyzstan";
        public string OfficialName => "Kyrgyz Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.KG;
        public Alpha3Code Alpha3Code => Alpha3Code.KGZ;
        public int NumericCode => 417;
        public string[] TLD => new [] { ".kg" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KZ,
            Alpha2Code.TJ,
            Alpha2Code.UZ,
        };

        public ICurrency[] Currencies => new [] { new KgsCurrency() };
        public string[] CallingCodes => new [] { "996" };
    }
}
