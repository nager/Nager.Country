using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahrain
    /// </summary>
    public class BahrainCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Bahrain";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Bahrain";
        ///<inheritdoc/>
        public string NativeName => "البحرين";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BH;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BHR;
        ///<inheritdoc/>
        public int NumericCode => 048;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bh" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BhdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "973" };
    }
}
