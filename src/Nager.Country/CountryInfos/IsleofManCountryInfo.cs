using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Isle of Man
    /// </summary>
    public class IsleofManCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Isle of Man";
        ///<inheritdoc/>
        public string OfficialName => "Isle of Man";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IMN;
        ///<inheritdoc/>
        public int NumericCode => 833;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".im" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "44" };
    }
}
