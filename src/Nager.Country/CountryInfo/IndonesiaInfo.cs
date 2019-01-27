namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Indonesia
    /// </summary>
    public class IndonesiaInfo : ICountryInfo
    {
        public string CommonName => "Indonesia";
        public string OfficialName => "Republic of Indonesia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إندونيسيا"),
            new Translation(LanguageCode.AZ, "İndoneziya"),
            new Translation(LanguageCode.BE, "Інданезія"),
            new Translation(LanguageCode.BG, "Индонезия"),
            new Translation(LanguageCode.BS, "Indonezija"),
            new Translation(LanguageCode.CA, "Indonèsia"),
            new Translation(LanguageCode.CS, "Indonésie"),
            new Translation(LanguageCode.DA, "Indonesien"),
            new Translation(LanguageCode.DE, "Indonesien"),
            new Translation(LanguageCode.EL, "Ινδονησία"),
            new Translation(LanguageCode.EN, "Indonesia"),
            new Translation(LanguageCode.ES, "Indonesia"),
            new Translation(LanguageCode.ET, "Indoneesia"),
            new Translation(LanguageCode.FA, "اندونزی"),
            new Translation(LanguageCode.FI, "Indonesia"),
            new Translation(LanguageCode.FR, "Indonésie"),
            new Translation(LanguageCode.HE, "אינדונזיה"),
            new Translation(LanguageCode.HR, "Indonezija"),
            new Translation(LanguageCode.HU, "Indonézia"),
            new Translation(LanguageCode.HY, "Ինդոնեզիա"),
            new Translation(LanguageCode.ID, "Indonesia"),
            new Translation(LanguageCode.IT, "Indonesia"),
            new Translation(LanguageCode.JA, "インドネシア"),
            new Translation(LanguageCode.KA, "ინდონეზია"),
            new Translation(LanguageCode.KK, "Индонезия"),
            new Translation(LanguageCode.KO, "인도네시아 공화국"),
            new Translation(LanguageCode.KY, "Индонезия"),
            new Translation(LanguageCode.LT, "Indonezija"),
            new Translation(LanguageCode.LV, "Indonēzija"),
            new Translation(LanguageCode.MK, "Индонезија"),
            new Translation(LanguageCode.MN, "Индонези"),
            new Translation(LanguageCode.NB, "Indonesia"),
            new Translation(LanguageCode.NL, "Indonesia"),
            new Translation(LanguageCode.NN, "Indonesia"),
            new Translation(LanguageCode.PL, "Indonezja"),
            new Translation(LanguageCode.PT, "Indonésia"),
            new Translation(LanguageCode.RO, "Indonezia"),
            new Translation(LanguageCode.RU, "Индонезия"),
            new Translation(LanguageCode.SK, "Indonézia"),
            new Translation(LanguageCode.SL, "Indonezija"),
            new Translation(LanguageCode.SR, "Индонезија"),
            new Translation(LanguageCode.SV, "Indonesien"),
            new Translation(LanguageCode.TR, "Endonezya"),
            new Translation(LanguageCode.UK, "Індонезія"),
            new Translation(LanguageCode.UZ, "Indoneziya"),
            new Translation(LanguageCode.ZH, "印尼"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ID;
        public Alpha3Code Alpha3Code => Alpha3Code.IDN;
        public int NumericCode => 360;
        public string[] TLD => new [] { ".id" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.TL,
            Alpha2Code.MY,
            Alpha2Code.PG,
        };

        public string[] Currencies => new [] { "IDR" };
        public string[] CallingCodes => new [] { "62" };
    }
}
