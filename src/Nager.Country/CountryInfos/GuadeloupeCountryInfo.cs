using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guadeloupe
    /// </summary>
    public class GuadeloupeCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Guadeloupe";
        ///<inheritdoc/>
        public string OfficialName => "Guadeloupe";
        ///<inheritdoc/>
        public string NativeName => "Guadeloupe";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GP;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GLP;
        ///<inheritdoc/>
        public int NumericCode => 312;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".gp" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "590" };
    }
}
