namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Czech Republic
    /// </summary>
    public class CzechRepublicInfo : ICountryInfo
    {
        public string CommonName => "Czechia";
        public string OfficialName => "Czech Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جمهورية التشيك"),
            new Translation(LanguageCode.AZ, "Çex Respublikası"),
            new Translation(LanguageCode.BE, "Чэхія"),
            new Translation(LanguageCode.BG, "Чехия"),
            new Translation(LanguageCode.BS, "Češka"),
            new Translation(LanguageCode.CA, "Txèquia"),
            new Translation(LanguageCode.CS, "Česko"),
            new Translation(LanguageCode.DA, "Tjekkiet"),
            new Translation(LanguageCode.DE, "Tschechische Republik"),
            new Translation(LanguageCode.EL, "Τσεχική Δημοκρατία"),
            new Translation(LanguageCode.EN, "Czech Republic"),
            new Translation(LanguageCode.ES, "República Checa"),
            new Translation(LanguageCode.ET, "Tšehhi"),
            new Translation(LanguageCode.FA, "جمهوری چک"),
            new Translation(LanguageCode.FI, "Tšekki"),
            new Translation(LanguageCode.FR, "Tchéquie"),
            new Translation(LanguageCode.HE, "צ׳כיה"),
            new Translation(LanguageCode.HR, "Češka"),
            new Translation(LanguageCode.HU, "Csehország"),
            new Translation(LanguageCode.HY, "Չեխիա"),
            new Translation(LanguageCode.ID, "Republik Ceko"),
            new Translation(LanguageCode.IT, "Repubblica Ceca"),
            new Translation(LanguageCode.JA, "チェコ"),
            new Translation(LanguageCode.KA, "ჩეხეთის რესპუბლიკა"),
            new Translation(LanguageCode.KK, "Чех Республикасы"),
            new Translation(LanguageCode.KO, "체코 공화국"),
            new Translation(LanguageCode.KY, "Чехия"),
            new Translation(LanguageCode.LT, "Čekija"),
            new Translation(LanguageCode.LV, "Čehija"),
            new Translation(LanguageCode.MK, "Чешка"),
            new Translation(LanguageCode.MN, "Чех"),
            new Translation(LanguageCode.NB, "Tsjekkia"),
            new Translation(LanguageCode.NL, "Tsjechië"),
            new Translation(LanguageCode.NN, "Tsjekkia"),
            new Translation(LanguageCode.PL, "Czechy"),
            new Translation(LanguageCode.PT, "República Tcheca"),
            new Translation(LanguageCode.RO, "Cehia"),
            new Translation(LanguageCode.RU, "Чехия"),
            new Translation(LanguageCode.SK, "Česko"),
            new Translation(LanguageCode.SL, "Češka"),
            new Translation(LanguageCode.SR, "Чешка"),
            new Translation(LanguageCode.SV, "Tjeckien"),
            new Translation(LanguageCode.TR, "Çek Cumhuriyeti"),
            new Translation(LanguageCode.UK, "Чехія"),
            new Translation(LanguageCode.UZ, "Chexiya"),
            new Translation(LanguageCode.ZH, "捷克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CZ;
        public Alpha3Code Alpha3Code => Alpha3Code.CZE;
        public int NumericCode => 203;
        public string[] TLD => new [] { ".cz" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.DE,
            Alpha2Code.PL,
            Alpha2Code.SK,
        };

        public string[] Currencies => new [] { "CZK" };
        public string[] CallingCodes => new [] { "420" };
    }
}
