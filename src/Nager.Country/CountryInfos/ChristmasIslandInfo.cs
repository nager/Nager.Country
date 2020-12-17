namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Christmas Island
    /// </summary>
    public class ChristmasIslandInfo : ICountryInfo
    {
        public string CommonName => "Christmas Island";
        public string OfficialName => "Territory of Christmas Island";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزيرة عيد الميلاد"),
            new Translation(LanguageCode.AZ, "Milad adası"),
            new Translation(LanguageCode.BE, "Востраў Каляд"),
            new Translation(LanguageCode.BG, "остров Рождество"),
            new Translation(LanguageCode.BS, "Božićna Ostrva"),
            new Translation(LanguageCode.CA, "Christmas, illa"),
            new Translation(LanguageCode.CS, "Vánoční ostrov"),
            new Translation(LanguageCode.DA, "Juløen"),
            new Translation(LanguageCode.DE, "Weihnachtsinsel"),
            new Translation(LanguageCode.EL, "Νήσος των Χριστουγέννων"),
            new Translation(LanguageCode.EN, "Christmas Island"),
            new Translation(LanguageCode.ES, "Isla de Navidad"),
            new Translation(LanguageCode.ET, "Jõulusaar"),
            new Translation(LanguageCode.FA, "جزیرهٔ کریسمس"),
            new Translation(LanguageCode.FI, "Joulusaari"),
            new Translation(LanguageCode.FR, "Île Christmas"),
            new Translation(LanguageCode.HE, "האי כריסטמס"),
            new Translation(LanguageCode.HR, "Božićni otok"),
            new Translation(LanguageCode.HU, "Karácsony-sziget"),
            new Translation(LanguageCode.HY, "Սուրբ Ծննդյան կղզի"),
            new Translation(LanguageCode.ID, "Pulau Natal"),
            new Translation(LanguageCode.IT, "Isola del Natale"),
            new Translation(LanguageCode.JA, "クリスマス島"),
            new Translation(LanguageCode.KA, "შობის კუნძული"),
            new Translation(LanguageCode.KK, "Рождество аралы"),
            new Translation(LanguageCode.KO, "크리스마스 섬"),
            new Translation(LanguageCode.KY, "Крисмас аралы"),
            new Translation(LanguageCode.LT, "Kalėdų Sala"),
            new Translation(LanguageCode.LV, "Ziemsvētku sala"),
            new Translation(LanguageCode.MK, "Божиќен Остров"),
            new Translation(LanguageCode.MN, "Зул сарын арал"),
            new Translation(LanguageCode.NB, "Christmasøya"),
            new Translation(LanguageCode.NL, "Christmaseiland"),
            new Translation(LanguageCode.NN, "Christmasøya"),
            new Translation(LanguageCode.PL, "Wyspa Bożego Narodzenia"),
            new Translation(LanguageCode.PT, "Ilha Christmas"),
            new Translation(LanguageCode.RO, "Insula Christmas"),
            new Translation(LanguageCode.RU, "Остров Рождества"),
            new Translation(LanguageCode.SK, "Vianočný ostrov"),
            new Translation(LanguageCode.SL, "Božični otok"),
            new Translation(LanguageCode.SR, "Божићно Острво"),
            new Translation(LanguageCode.SV, "Julön"),
            new Translation(LanguageCode.TR, "Christmas Adası"),
            new Translation(LanguageCode.UK, "Острів Різдва"),
            new Translation(LanguageCode.UZ, "Rojdestvo oroli"),
            new Translation(LanguageCode.ZH, "圣诞岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CX;
        public Alpha3Code Alpha3Code => Alpha3Code.CXR;
        public int NumericCode => 162;
        public string[] TLD => new [] { ".cx" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "AUD" };
        public string[] CallingCodes => new [] { "61" };
    }
}
