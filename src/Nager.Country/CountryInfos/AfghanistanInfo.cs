namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Afghanistan
    /// </summary>
    public class AfghanistanInfo : ICountryInfo
    {
        public string CommonName => "Afghanistan";
        public string OfficialName => "Islamic Republic of Afghanistan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أفغانستان"),
            new Translation(LanguageCode.AZ, "Əfqanıstan"),
            new Translation(LanguageCode.BE, "Афганістан"),
            new Translation(LanguageCode.BG, "Афганистан"),
            new Translation(LanguageCode.BS, "Afganistan"),
            new Translation(LanguageCode.CA, "Afganistan"),
            new Translation(LanguageCode.CS, "Afghánistán"),
            new Translation(LanguageCode.DA, "Afghanistan"),
            new Translation(LanguageCode.DE, "Afghanistan"),
            new Translation(LanguageCode.EL, "Αφγανιστάν"),
            new Translation(LanguageCode.EN, "Afghanistan"),
            new Translation(LanguageCode.ES, "Afganistán"),
            new Translation(LanguageCode.ET, "Afganistan"),
            new Translation(LanguageCode.FA, "افغانستان"),
            new Translation(LanguageCode.FI, "Afganistan"),
            new Translation(LanguageCode.FR, "Afghanistan"),
            new Translation(LanguageCode.HE, "אפגניסטן"),
            new Translation(LanguageCode.HR, "Afganistan"),
            new Translation(LanguageCode.HU, "Afganisztán"),
            new Translation(LanguageCode.HY, "Աֆղանստան"),
            new Translation(LanguageCode.ID, "Afghanistan"),
            new Translation(LanguageCode.IT, "Afghanistan"),
            new Translation(LanguageCode.JA, "アフガニスタン"),
            new Translation(LanguageCode.KA, "ავღანეთი"),
            new Translation(LanguageCode.KK, "Ауғанстан"),
            new Translation(LanguageCode.KO, "아프가니스탄"),
            new Translation(LanguageCode.KY, "Афганистан"),
            new Translation(LanguageCode.LT, "Afganistanas"),
            new Translation(LanguageCode.LV, "Afganistāna"),
            new Translation(LanguageCode.MK, "Авганистан"),
            new Translation(LanguageCode.MN, "Афганистан"),
            new Translation(LanguageCode.NB, "Afghanistan"),
            new Translation(LanguageCode.NL, "Afghanistan"),
            new Translation(LanguageCode.NN, "Afghanistan"),
            new Translation(LanguageCode.PL, "Afganistan"),
            new Translation(LanguageCode.PT, "Afeganistão"),
            new Translation(LanguageCode.RO, "Afganistan"),
            new Translation(LanguageCode.RU, "Афганистан"),
            new Translation(LanguageCode.SK, "Afganistan"),
            new Translation(LanguageCode.SL, "Afganistan"),
            new Translation(LanguageCode.SR, "Авганистан"),
            new Translation(LanguageCode.SV, "Afghanistan"),
            new Translation(LanguageCode.TR, "Afganistan"),
            new Translation(LanguageCode.UK, "Афганістан"),
            new Translation(LanguageCode.UZ, "Afgʻoniston"),
            new Translation(LanguageCode.ZH, "阿富汗"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AF;
        public Alpha3Code Alpha3Code => Alpha3Code.AFG;
        public int NumericCode => 004;
        public string[] TLD => new [] { ".af" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IR,
            Alpha2Code.PK,
            Alpha2Code.TM,
            Alpha2Code.UZ,
            Alpha2Code.TJ,
            Alpha2Code.CN,
        };

        public string[] Currencies => new [] { "AFN" };
        public string[] CallingCodes => new [] { "93" };
    }
}
