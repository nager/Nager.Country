using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Barbados
    /// </summary>
    public class BarbadosInfo : ICountryInfo
    {
        public string CommonName => "Barbados";
        public string OfficialName => "Barbados";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "باربادوس"),
            new Translation(LanguageCode.AZ, "Barbados"),
            new Translation(LanguageCode.BE, "Барбадас"),
            new Translation(LanguageCode.BG, "Барбадос"),
            new Translation(LanguageCode.BS, "Barbados"),
            new Translation(LanguageCode.CA, "Barbados"),
            new Translation(LanguageCode.CS, "Barbados"),
            new Translation(LanguageCode.DA, "Barbados"),
            new Translation(LanguageCode.DE, "Barbados"),
            new Translation(LanguageCode.EL, "Μπαρμπάντος"),
            new Translation(LanguageCode.EN, "Barbados"),
            new Translation(LanguageCode.ES, "Barbados"),
            new Translation(LanguageCode.ET, "Barbados"),
            new Translation(LanguageCode.FA, "باربادوس"),
            new Translation(LanguageCode.FI, "Barbados"),
            new Translation(LanguageCode.FR, "Barbade"),
            new Translation(LanguageCode.HE, "ברבדוס"),
            new Translation(LanguageCode.HR, "Barbados"),
            new Translation(LanguageCode.HU, "Barbados"),
            new Translation(LanguageCode.HY, "Բարբադոս"),
            new Translation(LanguageCode.ID, "Barbados"),
            new Translation(LanguageCode.IT, "Barbados"),
            new Translation(LanguageCode.JA, "バルバドス"),
            new Translation(LanguageCode.KA, "ბარბადოსი"),
            new Translation(LanguageCode.KK, "Барбадос"),
            new Translation(LanguageCode.KO, "바베이도스"),
            new Translation(LanguageCode.KY, "Барбадос"),
            new Translation(LanguageCode.LT, "Barbadosas"),
            new Translation(LanguageCode.LV, "Barbadosa"),
            new Translation(LanguageCode.MK, "Барбадос"),
            new Translation(LanguageCode.MN, "Барбадос"),
            new Translation(LanguageCode.NB, "Barbados"),
            new Translation(LanguageCode.NL, "Barbados"),
            new Translation(LanguageCode.NN, "Barbados"),
            new Translation(LanguageCode.PL, "Barbados"),
            new Translation(LanguageCode.PT, "Barbados"),
            new Translation(LanguageCode.RO, "Barbados"),
            new Translation(LanguageCode.RU, "Барбадос"),
            new Translation(LanguageCode.SK, "Barbados"),
            new Translation(LanguageCode.SL, "Barbados"),
            new Translation(LanguageCode.SR, "Барбадос"),
            new Translation(LanguageCode.SV, "Barbados"),
            new Translation(LanguageCode.TR, "Barbados"),
            new Translation(LanguageCode.UK, "Барбадос"),
            new Translation(LanguageCode.UZ, "Barbados"),
            new Translation(LanguageCode.ZH, "巴巴多斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BB;
        public Alpha3Code Alpha3Code => Alpha3Code.BRB;
        public int NumericCode => 052;
        public string[] TLD => new [] { ".bb" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new BbdCurrency() };
        public string[] CallingCodes => new [] { "1246" };
    }
}
