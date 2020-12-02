namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Bouvet Island
    /// </summary>
    public class BouvetIslandInfo : ICountryInfo
    {
        public string CommonName => "Bouvet Island";
        public string OfficialName => "Bouvet Island";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزيرة بوفيه"),
            new Translation(LanguageCode.AZ, "Buve adası"),
            new Translation(LanguageCode.BE, "Востраў Бувэ"),
            new Translation(LanguageCode.BG, "остров Буве"),
            new Translation(LanguageCode.BS, "Ostrvo Buve"),
            new Translation(LanguageCode.CA, "Bouvet"),
            new Translation(LanguageCode.CS, "Bouvetův ostrov"),
            new Translation(LanguageCode.DA, "Bouvet Island"),
            new Translation(LanguageCode.DE, "Bouvetinsel"),
            new Translation(LanguageCode.EL, "Μπουβέ"),
            new Translation(LanguageCode.EN, "Bouvet Island"),
            new Translation(LanguageCode.ES, "Isla Bouvet"),
            new Translation(LanguageCode.ET, "Bouvet’i saar"),
            new Translation(LanguageCode.FA, "جزیرهٔ بووه"),
            new Translation(LanguageCode.FI, "Bouvet’nsaari"),
            new Translation(LanguageCode.FR, "Île Bouvet"),
            new Translation(LanguageCode.HE, "איי בובה"),
            new Translation(LanguageCode.HR, "Otok Bouvet"),
            new Translation(LanguageCode.HU, "Bouvet-sziget"),
            new Translation(LanguageCode.HY, "Բուվե կղզի"),
            new Translation(LanguageCode.ID, "Kepulauan Bouvet"),
            new Translation(LanguageCode.IT, "Isola Bouvet"),
            new Translation(LanguageCode.JA, "ブーベ島"),
            new Translation(LanguageCode.KA, "ბუვე"),
            new Translation(LanguageCode.KK, "Буве аралы"),
            new Translation(LanguageCode.KO, "부베 섬"),
            new Translation(LanguageCode.KY, "Буве аралдары"),
            new Translation(LanguageCode.LT, "Buvė Sala"),
            new Translation(LanguageCode.LV, "Buvē sala"),
            new Translation(LanguageCode.MK, "Остров Буве"),
            new Translation(LanguageCode.MN, "Буветын арлууд"),
            new Translation(LanguageCode.NB, "Bouvetøya"),
            new Translation(LanguageCode.NL, "Bouvet Eiland"),
            new Translation(LanguageCode.NN, "Bouvetøya"),
            new Translation(LanguageCode.PL, "Wyspa Bouveta"),
            new Translation(LanguageCode.PT, "Ilhas Bouvet"),
            new Translation(LanguageCode.RO, "Insula Bouvet"),
            new Translation(LanguageCode.RU, "Остров Буве"),
            new Translation(LanguageCode.SK, "Bouvetov ostrov"),
            new Translation(LanguageCode.SL, "Bouvetov otok"),
            new Translation(LanguageCode.SR, "Острво Буве"),
            new Translation(LanguageCode.SV, "Bouvetön"),
            new Translation(LanguageCode.TR, "Bouvet Adası"),
            new Translation(LanguageCode.UK, "Острів Буве"),
            new Translation(LanguageCode.UZ, "Buve oroli"),
            new Translation(LanguageCode.ZH, "布韦岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BV;
        public Alpha3Code Alpha3Code => Alpha3Code.BVT;
        public int NumericCode => 074;
        public string[] TLD => new [] { ".bv" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "NOK" };
        public string[] CallingCodes => new string[0];
    }
}
