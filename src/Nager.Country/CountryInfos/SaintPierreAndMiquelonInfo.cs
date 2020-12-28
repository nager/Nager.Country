using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public class SaintPierreAndMiquelonInfo : ICountryInfo
    {
        public string CommonName => "Saint Pierre and Miquelon";
        public string OfficialName => "Saint Pierre and Miquelon";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سان بيير وميكلون"),
            new Translation(LanguageCode.AZ, "Müqəddəs Pyer və Mikelon"),
            new Translation(LanguageCode.BE, "Сен-П’ер і Мікелон"),
            new Translation(LanguageCode.BG, "Сен Пиер и Микелон"),
            new Translation(LanguageCode.BS, "Sveti Petar i Mikelon"),
            new Translation(LanguageCode.CA, "Saint-Pierre i Miquelon"),
            new Translation(LanguageCode.CS, "Saint-Pierre a Miquelon"),
            new Translation(LanguageCode.DA, "Saint-Pierre og Miquelon"),
            new Translation(LanguageCode.DE, "Saint-Pierre und Miquelon"),
            new Translation(LanguageCode.EL, "Σαιν Πιερ και Μικελόν"),
            new Translation(LanguageCode.EN, "Saint Pierre and Miquelon"),
            new Translation(LanguageCode.ES, "San Pedro y Miquelón"),
            new Translation(LanguageCode.ET, "Saint Pierre ja Miquelon"),
            new Translation(LanguageCode.FA, "سن پیر و میکلن"),
            new Translation(LanguageCode.FI, "Saint-Pierre ja Miquelon"),
            new Translation(LanguageCode.FR, "Saint Pierre and Miquelon"),
            new Translation(LanguageCode.HE, "סנט פייר ומיקלון"),
            new Translation(LanguageCode.HR, "Saint-Pierre-et-Miquelon"),
            new Translation(LanguageCode.HU, "Saint Pierre and Miquelon"),
            new Translation(LanguageCode.HY, "Սեն Պիեռ և Միքելոն"),
            new Translation(LanguageCode.ID, "Saint Pierre dan Miquelon"),
            new Translation(LanguageCode.IT, "Saint Pierre e Miquelon"),
            new Translation(LanguageCode.JA, "サンピエール島・ミクロン島"),
            new Translation(LanguageCode.KA, "სენ-პიერი და მიკელონი"),
            new Translation(LanguageCode.KK, "Сен-Пьер және Микелон"),
            new Translation(LanguageCode.KO, "생 피에르 미 클롱"),
            new Translation(LanguageCode.KY, "Сен-Пьер жана Микелон"),
            new Translation(LanguageCode.LT, "Sen Pjeras ir Mikelonas"),
            new Translation(LanguageCode.LV, "Senpjēra un Mikelona"),
            new Translation(LanguageCode.MK, "Сент Пјер и Микелан"),
            new Translation(LanguageCode.MN, "Сэнт Пьер ба Микелон"),
            new Translation(LanguageCode.NB, "Saint-Pierre-et-Miquelon"),
            new Translation(LanguageCode.NL, "Saint-Pierre en Miquelon"),
            new Translation(LanguageCode.NN, "Saint-Pierre-et-Miquelon"),
            new Translation(LanguageCode.PL, "Saint-Pierre i Miquelon"),
            new Translation(LanguageCode.PT, "Saint Pierre e Miquelon"),
            new Translation(LanguageCode.RO, "Saint-Pierre și Miquelon"),
            new Translation(LanguageCode.RU, "Сен-Пьер и Микелон"),
            new Translation(LanguageCode.SK, "Saint Pierre a Miquelon"),
            new Translation(LanguageCode.SL, "Saint Pierre in Miquelon"),
            new Translation(LanguageCode.SR, "Сен Пјер и Микелон"),
            new Translation(LanguageCode.SV, "Saint-Pierre och Miquelon"),
            new Translation(LanguageCode.TR, "Saint Pierre ve Miquelon"),
            new Translation(LanguageCode.UK, "Сен-П'єр і Мікелон"),
            new Translation(LanguageCode.UZ, "Sen-Pyer va Mikelon"),
            new Translation(LanguageCode.ZH, "圣皮埃尔和密克隆"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PM;
        public Alpha3Code Alpha3Code => Alpha3Code.SPM;
        public int NumericCode => 666;
        public string[] TLD => new [] { ".pm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "508" };
    }
}
