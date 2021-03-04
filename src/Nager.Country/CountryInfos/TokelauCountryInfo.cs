using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tokelau
    /// </summary>
    public class TokelauCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Tokelau";
        ///<inheritdoc/>
        public string OfficialName => "Tokelau";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TK;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TKL;
        ///<inheritdoc/>
        public int NumericCode => 772;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tk" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "690" };
    }
}
