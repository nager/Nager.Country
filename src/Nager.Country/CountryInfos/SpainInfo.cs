using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Spain
    /// </summary>
    public class SpainInfo : ICountryInfo
    {
        public string CommonName => "Spain";
        public string OfficialName => "Kingdom of Spain";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إسبانيا"),
            new Translation(LanguageCode.AZ, "İspaniya"),
            new Translation(LanguageCode.BE, "Іспанія"),
            new Translation(LanguageCode.BG, "Испания"),
            new Translation(LanguageCode.BS, "Španija"),
            new Translation(LanguageCode.CA, "Espanya"),
            new Translation(LanguageCode.CS, "Španělsko"),
            new Translation(LanguageCode.DA, "Spanien"),
            new Translation(LanguageCode.DE, "Spanien"),
            new Translation(LanguageCode.EL, "Ισπανία"),
            new Translation(LanguageCode.EN, "Spain"),
            new Translation(LanguageCode.ES, "España"),
            new Translation(LanguageCode.ET, "Hispaania"),
            new Translation(LanguageCode.FA, "اسپانیا"),
            new Translation(LanguageCode.FI, "Espanja"),
            new Translation(LanguageCode.FR, "Espagne"),
            new Translation(LanguageCode.HE, "ספרד"),
            new Translation(LanguageCode.HR, "Španjolska"),
            new Translation(LanguageCode.HU, "Spanyolország"),
            new Translation(LanguageCode.HY, "Իսպանիա"),
            new Translation(LanguageCode.ID, "Spanyol"),
            new Translation(LanguageCode.IT, "Spagna"),
            new Translation(LanguageCode.JA, "スペイン"),
            new Translation(LanguageCode.KA, "ესპანეთი"),
            new Translation(LanguageCode.KK, "Испания"),
            new Translation(LanguageCode.KO, "스페인"),
            new Translation(LanguageCode.KY, "Испания"),
            new Translation(LanguageCode.LT, "Ispanija"),
            new Translation(LanguageCode.LV, "Spānija"),
            new Translation(LanguageCode.MK, "Шпанија"),
            new Translation(LanguageCode.MN, "Испани"),
            new Translation(LanguageCode.NB, "Spania"),
            new Translation(LanguageCode.NL, "Spanje"),
            new Translation(LanguageCode.NN, "Spania"),
            new Translation(LanguageCode.PL, "Hiszpania"),
            new Translation(LanguageCode.PT, "Espanha"),
            new Translation(LanguageCode.RO, "Spania"),
            new Translation(LanguageCode.RU, "Испания"),
            new Translation(LanguageCode.SK, "Španielsko"),
            new Translation(LanguageCode.SL, "Španija"),
            new Translation(LanguageCode.SR, "Шпанија"),
            new Translation(LanguageCode.SV, "Spanien"),
            new Translation(LanguageCode.TR, "İspanya"),
            new Translation(LanguageCode.UK, "Іспанія"),
            new Translation(LanguageCode.UZ, "Ispaniya"),
            new Translation(LanguageCode.ZH, "西班牙"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ES;
        public Alpha3Code Alpha3Code => Alpha3Code.ESP;
        public int NumericCode => 724;
        public string[] TLD => new [] { ".es" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AD,
            Alpha2Code.FR,
            Alpha2Code.GI,
            Alpha2Code.PT,
            Alpha2Code.MA,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "34" };
    }
}
