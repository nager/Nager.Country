using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Faroe Islands
    /// </summary>
    public class FaroeIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Faroe Islands";
        ///<inheritdoc/>
        public string OfficialName => "Faroe Islands";
        ///<inheritdoc/>
        public string NativeName => "Føroyar";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FRO;
        ///<inheritdoc/>
        public int NumericCode => 234;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".fo" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new DkkCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "298" };
    }
}
