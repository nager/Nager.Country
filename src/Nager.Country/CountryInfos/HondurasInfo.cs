using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Honduras
    /// </summary>
    public class HondurasInfo : ICountryInfo
    {
        public string CommonName => "Honduras";
        public string OfficialName => "Republic of Honduras";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "هندوراس"),
            new Translation(LanguageCode.AZ, "Honduras"),
            new Translation(LanguageCode.BE, "Гандурас"),
            new Translation(LanguageCode.BG, "Хондурас"),
            new Translation(LanguageCode.BS, "Honduras"),
            new Translation(LanguageCode.CA, "Hondures"),
            new Translation(LanguageCode.CS, "Honduras"),
            new Translation(LanguageCode.DA, "Honduras"),
            new Translation(LanguageCode.DE, "Honduras"),
            new Translation(LanguageCode.EL, "Ονδούρα"),
            new Translation(LanguageCode.EN, "Honduras"),
            new Translation(LanguageCode.ES, "Honduras"),
            new Translation(LanguageCode.ET, "Honduras"),
            new Translation(LanguageCode.FA, "هندوراس"),
            new Translation(LanguageCode.FI, "Honduras"),
            new Translation(LanguageCode.FR, "Honduras"),
            new Translation(LanguageCode.HE, "הונדורס"),
            new Translation(LanguageCode.HR, "Honduras"),
            new Translation(LanguageCode.HU, "Honduras"),
            new Translation(LanguageCode.HY, "Հոնդուրաս"),
            new Translation(LanguageCode.ID, "Honduras"),
            new Translation(LanguageCode.IT, "Honduras"),
            new Translation(LanguageCode.JA, "ホンジュラス"),
            new Translation(LanguageCode.KA, "ჰონდურასი"),
            new Translation(LanguageCode.KK, "Гондурас"),
            new Translation(LanguageCode.KO, "온두라스"),
            new Translation(LanguageCode.KY, "Гондурас"),
            new Translation(LanguageCode.LT, "Hondūras"),
            new Translation(LanguageCode.LV, "Hondurasa"),
            new Translation(LanguageCode.MK, "Хондурас"),
            new Translation(LanguageCode.MN, "Гондурас"),
            new Translation(LanguageCode.NB, "Honduras"),
            new Translation(LanguageCode.NL, "Honduras"),
            new Translation(LanguageCode.NN, "Honduras"),
            new Translation(LanguageCode.PL, "Honduras"),
            new Translation(LanguageCode.PT, "Honduras"),
            new Translation(LanguageCode.RO, "Honduras"),
            new Translation(LanguageCode.RU, "Гондурас"),
            new Translation(LanguageCode.SK, "Honduras"),
            new Translation(LanguageCode.SL, "Honduras"),
            new Translation(LanguageCode.SR, "Хондурас"),
            new Translation(LanguageCode.SV, "Honduras"),
            new Translation(LanguageCode.TR, "Honduras"),
            new Translation(LanguageCode.UK, "Гондурас"),
            new Translation(LanguageCode.UZ, "Gonduras"),
            new Translation(LanguageCode.ZH, "宏都拉斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.HN;
        public Alpha3Code Alpha3Code => Alpha3Code.HND;
        public int NumericCode => 340;
        public string[] TLD => new [] { ".hn" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.SV,
            Alpha2Code.NI,
        };

        public ICurrency[] Currencies => new [] { new HnlCurrency() };
        public string[] CallingCodes => new [] { "504" };
    }
}
