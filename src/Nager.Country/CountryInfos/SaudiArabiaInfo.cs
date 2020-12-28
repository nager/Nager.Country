using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saudi Arabia
    /// </summary>
    public class SaudiArabiaInfo : ICountryInfo
    {
        public string CommonName => "Saudi Arabia";
        public string OfficialName => "Kingdom of Saudi Arabia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "السعودية"),
            new Translation(LanguageCode.AZ, "Səudiyyə Ərəbistanı"),
            new Translation(LanguageCode.BE, "Саудаўская Аравія"),
            new Translation(LanguageCode.BG, "Саудитска Арабия"),
            new Translation(LanguageCode.BS, "Saudijska Arabija"),
            new Translation(LanguageCode.CA, "Aràbia Saudita"),
            new Translation(LanguageCode.CS, "Saúdská Arábie"),
            new Translation(LanguageCode.DA, "Saudi-Arabien"),
            new Translation(LanguageCode.DE, "Saudi-Arabien"),
            new Translation(LanguageCode.EL, "Σαουδική Αραβία"),
            new Translation(LanguageCode.EN, "Saudi Arabia"),
            new Translation(LanguageCode.ES, "Arabia Saudita"),
            new Translation(LanguageCode.ET, "Saudi Araabia"),
            new Translation(LanguageCode.FA, "عربستان سعودی"),
            new Translation(LanguageCode.FI, "Saudi-Arabia"),
            new Translation(LanguageCode.FR, "Arabie Saoudite"),
            new Translation(LanguageCode.HE, "ערב הסעודית"),
            new Translation(LanguageCode.HR, "Saudijska Arabija"),
            new Translation(LanguageCode.HU, "Szaudi-Arábia"),
            new Translation(LanguageCode.HY, "Սաուդյան Արաբիա"),
            new Translation(LanguageCode.ID, "Arab Saudi"),
            new Translation(LanguageCode.IT, "Arabia Saudita"),
            new Translation(LanguageCode.JA, "サウジアラビア"),
            new Translation(LanguageCode.KA, "საუდის არაბეთი"),
            new Translation(LanguageCode.KK, "Сауд Арабиясы"),
            new Translation(LanguageCode.KO, "사우디 아라비아"),
            new Translation(LanguageCode.KY, "Сауд Арабиясы"),
            new Translation(LanguageCode.LT, "Saudo Arabija"),
            new Translation(LanguageCode.LV, "Saūda Arābija"),
            new Translation(LanguageCode.MK, "Саудиска Арабија"),
            new Translation(LanguageCode.MN, "Саудын Араб"),
            new Translation(LanguageCode.NB, "Saudi-Arabia"),
            new Translation(LanguageCode.NL, "Saudi-Arabië"),
            new Translation(LanguageCode.NN, "Saudi-Arabia"),
            new Translation(LanguageCode.PL, "Arabia Saudyjska"),
            new Translation(LanguageCode.PT, "Arábia Saudita"),
            new Translation(LanguageCode.RO, "Arabia Saudită"),
            new Translation(LanguageCode.RU, "Саудовская Аравия"),
            new Translation(LanguageCode.SK, "Saudská Arábia"),
            new Translation(LanguageCode.SL, "Saudova Arabija"),
            new Translation(LanguageCode.SR, "Саудијска Арабија"),
            new Translation(LanguageCode.SV, "Saudiarabien"),
            new Translation(LanguageCode.TR, "Suudi Arabistan"),
            new Translation(LanguageCode.UK, "Саудівська Аравія"),
            new Translation(LanguageCode.UZ, "Saudiya Arabistoni"),
            new Translation(LanguageCode.ZH, "沙乌地阿拉伯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SA;
        public Alpha3Code Alpha3Code => Alpha3Code.SAU;
        public int NumericCode => 682;
        public string[] TLD => new [] { ".sa", ".السعودية" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.JO,
            Alpha2Code.KW,
            Alpha2Code.OM,
            Alpha2Code.QA,
            Alpha2Code.AE,
            Alpha2Code.YE,
        };

        public ICurrency[] Currencies => new [] { new SarCurrency() };
        public string[] CallingCodes => new [] { "966" };
    }
}
