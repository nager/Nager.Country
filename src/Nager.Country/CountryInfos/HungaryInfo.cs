namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Hungary
    /// </summary>
    public class HungaryInfo : ICountryInfo
    {
        public string CommonName => "Hungary";
        public string OfficialName => "Hungary";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "المجر"),
            new Translation(LanguageCode.AZ, "Macarıstan"),
            new Translation(LanguageCode.BE, "Венгрыя"),
            new Translation(LanguageCode.BG, "Унгария"),
            new Translation(LanguageCode.BS, "Mađarska"),
            new Translation(LanguageCode.CA, "Hongria"),
            new Translation(LanguageCode.CS, "Maďarsko"),
            new Translation(LanguageCode.DA, "Ungarn"),
            new Translation(LanguageCode.DE, "Ungarn"),
            new Translation(LanguageCode.EL, "Ουγγαρία"),
            new Translation(LanguageCode.EN, "Hungary"),
            new Translation(LanguageCode.ES, "Hungría"),
            new Translation(LanguageCode.ET, "Ungari"),
            new Translation(LanguageCode.FA, "مجارستان"),
            new Translation(LanguageCode.FI, "Unkari"),
            new Translation(LanguageCode.FR, "Hongrie"),
            new Translation(LanguageCode.HE, "הונגריה"),
            new Translation(LanguageCode.HR, "Mađarska"),
            new Translation(LanguageCode.HU, "Magyarország"),
            new Translation(LanguageCode.HY, "Հունգարիա"),
            new Translation(LanguageCode.ID, "Hungaria"),
            new Translation(LanguageCode.IT, "Ungheria"),
            new Translation(LanguageCode.JA, "ハンガリー"),
            new Translation(LanguageCode.KA, "უნგრეთი"),
            new Translation(LanguageCode.KK, "Венгрия"),
            new Translation(LanguageCode.KO, "헝가리"),
            new Translation(LanguageCode.KY, "Венгрия"),
            new Translation(LanguageCode.LT, "Vengrija"),
            new Translation(LanguageCode.LV, "Ungārija"),
            new Translation(LanguageCode.MK, "Унгарија"),
            new Translation(LanguageCode.MN, "Унгар"),
            new Translation(LanguageCode.NB, "Ungarn"),
            new Translation(LanguageCode.NL, "Hongarije"),
            new Translation(LanguageCode.NN, "Ungarn"),
            new Translation(LanguageCode.PL, "Węgry"),
            new Translation(LanguageCode.PT, "Hungria"),
            new Translation(LanguageCode.RO, "Ungaria"),
            new Translation(LanguageCode.RU, "Венгрия"),
            new Translation(LanguageCode.SK, "Maďarsko"),
            new Translation(LanguageCode.SL, "Madžarska"),
            new Translation(LanguageCode.SR, "Мађарска"),
            new Translation(LanguageCode.SV, "Ungern"),
            new Translation(LanguageCode.TR, "Macaristan"),
            new Translation(LanguageCode.UK, "Угорщина"),
            new Translation(LanguageCode.UZ, "Vengriya"),
            new Translation(LanguageCode.ZH, "匈牙利"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.HU;
        public Alpha3Code Alpha3Code => Alpha3Code.HUN;
        public int NumericCode => 348;
        public string[] TLD => new [] { ".hu" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.HR,
            Alpha2Code.RO,
            Alpha2Code.RS,
            Alpha2Code.SK,
            Alpha2Code.SI,
            Alpha2Code.UA,
        };

        public string[] Currencies => new [] { "HUF" };
        public string[] CallingCodes => new [] { "36" };
    }
}
