namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Falkland Islands
    /// </summary>
    public class FalklandIslandsInfo : ICountryInfo
    {
        public string CommonName => "Falkland Islands";
        public string OfficialName => "Falkland Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر فوكلاند"),
            new Translation(LanguageCode.AZ, "Folklend adaları"),
            new Translation(LanguageCode.BE, "Фалклендскія астравы"),
            new Translation(LanguageCode.BG, "Фолклендски острови"),
            new Translation(LanguageCode.BS, "Folklandska Ostrva"),
            new Translation(LanguageCode.CA, "Malvines, illes"),
            new Translation(LanguageCode.CS, "Falklandy (Malvíny)"),
            new Translation(LanguageCode.DA, "Falklandsøerne"),
            new Translation(LanguageCode.DE, "Falklandinseln"),
            new Translation(LanguageCode.EL, "Νήσοι Φώκλαντ (Μαλβίνας)"),
            new Translation(LanguageCode.EN, "Falkland Islands (Malvinas)"),
            new Translation(LanguageCode.ES, "Islas Malvinas"),
            new Translation(LanguageCode.ET, "Falklandi saared"),
            new Translation(LanguageCode.FA, "جزایر فالکلند"),
            new Translation(LanguageCode.FI, "Falklandinsaaret"),
            new Translation(LanguageCode.FR, "Îles Malouines"),
            new Translation(LanguageCode.HE, "איי פוקלנד"),
            new Translation(LanguageCode.HR, "Falklandski otoci"),
            new Translation(LanguageCode.HU, "Falkland-szigetek"),
            new Translation(LanguageCode.HY, "Ֆոլքլենդյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Falkland(Malvinas)"),
            new Translation(LanguageCode.IT, "Isole Falkland"),
            new Translation(LanguageCode.JA, "フォークランド（マルビナス）諸島"),
            new Translation(LanguageCode.KA, "ფოლკლენდის კუნძულები"),
            new Translation(LanguageCode.KK, "Фолкленд аралдары"),
            new Translation(LanguageCode.KO, "포클랜드 제도 (말 비나 스)"),
            new Translation(LanguageCode.KY, "Фолклэнд аралдары"),
            new Translation(LanguageCode.LT, "Folklando Salos"),
            new Translation(LanguageCode.LV, "Folklenda salas"),
            new Translation(LanguageCode.MK, "Фолкландски Острови"),
            new Translation(LanguageCode.MN, "Фолькландын Арлууд"),
            new Translation(LanguageCode.NB, "Falklandsøyene"),
            new Translation(LanguageCode.NL, "Falklandeilanden"),
            new Translation(LanguageCode.NN, "Falklandsøyane"),
            new Translation(LanguageCode.PL, "Falklandy"),
            new Translation(LanguageCode.PT, "Ilhas Malvinas"),
            new Translation(LanguageCode.RO, "Insulele Falkland"),
            new Translation(LanguageCode.RU, "Фолклендские острова"),
            new Translation(LanguageCode.SK, "Falklandy"),
            new Translation(LanguageCode.SL, "Falklandski otoki"),
            new Translation(LanguageCode.SR, "Фокландска Острва"),
            new Translation(LanguageCode.SV, "Falklandsöarna"),
            new Translation(LanguageCode.TR, "Falkland Adaları"),
            new Translation(LanguageCode.UK, "Фолклендські Острови"),
            new Translation(LanguageCode.UZ, "Folklend orollari"),
            new Translation(LanguageCode.ZH, "福克兰群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.FK;
        public Alpha3Code Alpha3Code => Alpha3Code.FLK;
        public int NumericCode => 238;
        public string[] TLD => new [] { ".fk" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "FKP" };
        public string[] CallingCodes => new [] { "500" };
    }
}
