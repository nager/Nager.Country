using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United Arab Emirates
    /// </summary>
    public class UnitedArabEmiratesCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "United Arab Emirates";
        ///<inheritdoc/>
        public string OfficialName => "United Arab Emirates";
        ///<inheritdoc/>
        public string NativeName => "دولة الإمارات العربية المتحدة";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ARE;
        ///<inheritdoc/>
        public int NumericCode => 784;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ae", "امارات." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.OM,
            Alpha2Code.SA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AedCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "971" };
    }
}
