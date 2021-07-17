using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    public class SaintBarthelemyCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Saint Barthélemy";
        ///<inheritdoc/>
        public string OfficialName => "Collectivity of Saint BarthélemySaint Barthélemy";
        ///<inheritdoc/>
        public string NativeName => "Saint-Barthélemy";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BL;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BLM;
        ///<inheritdoc/>
        public int NumericCode => 652;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bl" };

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
