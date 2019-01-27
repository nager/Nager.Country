namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Vietnam
    /// </summary>
    public class VietnamInfo : ICountryInfo
    {
        public string CommonName => "Vietnam";
        public string OfficialName => "Socialist Republic of Vietnam";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "فيتنام"),
            new Translation(LanguageCode.AZ, "Vyetnam"),
            new Translation(LanguageCode.BE, "В’етнам"),
            new Translation(LanguageCode.BG, "Виетнам"),
            new Translation(LanguageCode.BS, "Vijetnam"),
            new Translation(LanguageCode.CA, "Vietnam"),
            new Translation(LanguageCode.CS, "Vietnam"),
            new Translation(LanguageCode.DA, "Vietnam"),
            new Translation(LanguageCode.DE, "Vietnam"),
            new Translation(LanguageCode.EL, "Βιετνάμ"),
            new Translation(LanguageCode.EN, "Viet Nam"),
            new Translation(LanguageCode.ES, "Vietnam"),
            new Translation(LanguageCode.ET, "Vietnam"),
            new Translation(LanguageCode.FA, "ویتنام"),
            new Translation(LanguageCode.FI, "Vietnam"),
            new Translation(LanguageCode.FR, "Vietnam"),
            new Translation(LanguageCode.HE, "וייטנאם"),
            new Translation(LanguageCode.HR, "Vijetnam"),
            new Translation(LanguageCode.HU, "Vietnam"),
            new Translation(LanguageCode.HY, "Վիետնամ"),
            new Translation(LanguageCode.ID, "Viet Nam"),
            new Translation(LanguageCode.IT, "Vietnam"),
            new Translation(LanguageCode.JA, "ベトナム"),
            new Translation(LanguageCode.KA, "ვიეტნამი"),
            new Translation(LanguageCode.KK, "Вьетнам"),
            new Translation(LanguageCode.KO, "베트남"),
            new Translation(LanguageCode.KY, "Вьетнам"),
            new Translation(LanguageCode.LT, "Vietnamas"),
            new Translation(LanguageCode.LV, "Vjetnama"),
            new Translation(LanguageCode.MK, "Виетнам"),
            new Translation(LanguageCode.MN, "Вьетнам"),
            new Translation(LanguageCode.NB, "Vietnam"),
            new Translation(LanguageCode.NL, "Vietnam"),
            new Translation(LanguageCode.NN, "Vietnam"),
            new Translation(LanguageCode.PL, "Wietnam"),
            new Translation(LanguageCode.PT, "Vietnã"),
            new Translation(LanguageCode.RO, "Vietnam"),
            new Translation(LanguageCode.RU, "Вьетнам"),
            new Translation(LanguageCode.SK, "Vietnam"),
            new Translation(LanguageCode.SL, "Vietnam"),
            new Translation(LanguageCode.SR, "Вијетнам"),
            new Translation(LanguageCode.SV, "Vietnam"),
            new Translation(LanguageCode.TR, "Vietnam"),
            new Translation(LanguageCode.UK, "В'єтнам"),
            new Translation(LanguageCode.UZ, "Vyetnam"),
            new Translation(LanguageCode.ZH, "越南"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.VN;
        public Alpha3Code Alpha3Code => Alpha3Code.VNM;
        public int NumericCode => 704;
        public string[] TLD => new [] { ".vn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.LA,
        };

        public string[] Currencies => new [] { "VND" };
        public string[] CallingCodes => new [] { "84" };
    }
}
