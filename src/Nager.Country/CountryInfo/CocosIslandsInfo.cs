namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Cocos (Keeling) Islands
    /// </summary>
    public class CocosIslandsInfo : ICountryInfo
    {
        public string CommonName => "Cocos (Keeling) Islands";
        public string OfficialName => "Territory of the Cocos (Keeling) Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر كوكوس"),
            new Translation(LanguageCode.AZ, "Kokos (Kilinq) adaları"),
            new Translation(LanguageCode.BE, "Какосавыя (Кілінг) астравы"),
            new Translation(LanguageCode.BG, "Кокосови острови (острови Кийлинг)"),
            new Translation(LanguageCode.BS, "Kokosova (Kilingova) Ostrva"),
            new Translation(LanguageCode.CA, "Cocos, illes"),
            new Translation(LanguageCode.CS, "Kokosové ostrovy"),
            new Translation(LanguageCode.DA, "Cocosøerne"),
            new Translation(LanguageCode.DE, "Kokosinseln"),
            new Translation(LanguageCode.EL, "Νησιά Κόκος"),
            new Translation(LanguageCode.EN, "Cocos (Keeling) Islands"),
            new Translation(LanguageCode.ES, "Islas Cocos (Keeling)"),
            new Translation(LanguageCode.ET, "Kookossaared"),
            new Translation(LanguageCode.FA, "جزایر کوکوس"),
            new Translation(LanguageCode.FI, "Kookossaaret"),
            new Translation(LanguageCode.FR, "Cocos"),
            new Translation(LanguageCode.HE, "איי קוקוס (קילינג)"),
            new Translation(LanguageCode.HR, "Kokosovi (Keelingovi) otoci"),
            new Translation(LanguageCode.HU, "Kókusz (Keeling)-szigetek"),
            new Translation(LanguageCode.HY, "Կոկոսյան (Քիլինգ) կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Cocos (Keeling)"),
            new Translation(LanguageCode.IT, "Isole Cocos e Keeling"),
            new Translation(LanguageCode.JA, "ココス（キーリング）諸島"),
            new Translation(LanguageCode.KA, "ქოქოსის (კილინგის) კუნძულები"),
            new Translation(LanguageCode.KK, "Кокос (Килинг) аралдары"),
            new Translation(LanguageCode.KO, "코코스 군도"),
            new Translation(LanguageCode.KY, "Кокос (Килиӊ) аралдары"),
            new Translation(LanguageCode.LT, "Kokosų (Kilingo) Salos"),
            new Translation(LanguageCode.LV, "Kokosu (Kīlinga) salas"),
            new Translation(LanguageCode.MK, "Кокосови (Килиншки) Острови"),
            new Translation(LanguageCode.MN, "Кокос (Кийлинг) арлууд"),
            new Translation(LanguageCode.NB, "Kokosøyene"),
            new Translation(LanguageCode.NL, "Cocoseilanden"),
            new Translation(LanguageCode.NN, "Kokosøyane"),
            new Translation(LanguageCode.PL, "Wyspy Kokosowe"),
            new Translation(LanguageCode.PT, "Ilhas Cocos (Keeling)"),
            new Translation(LanguageCode.RO, "Insulele Cocos (Keeling)"),
            new Translation(LanguageCode.RU, "Кокосовые острова"),
            new Translation(LanguageCode.SK, "Kokosové ostrovy"),
            new Translation(LanguageCode.SL, "Kokosovi otoki"),
            new Translation(LanguageCode.SR, "Кокосова (Килингова) Острва"),
            new Translation(LanguageCode.SV, "Kokosöarna"),
            new Translation(LanguageCode.TR, "Cocos (Keeling) Adaları"),
            new Translation(LanguageCode.UK, "Кокосові острови"),
            new Translation(LanguageCode.UZ, "Kokos (Kiling) orollari"),
            new Translation(LanguageCode.ZH, "科科斯（基林）群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CC;
        public Alpha3Code Alpha3Code => Alpha3Code.CCK;
        public int NumericCode => 166;
        public string[] TLD => new [] { ".cc" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "AUD" };
        public string[] CallingCodes => new [] { "61" };
    }
}
