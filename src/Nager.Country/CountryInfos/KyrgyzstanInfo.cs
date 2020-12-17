namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    public class KyrgyzstanInfo : ICountryInfo
    {
        public string CommonName => "Kyrgyzstan";
        public string OfficialName => "Kyrgyz Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "قيرغيزستان"),
            new Translation(LanguageCode.AZ, "Qırğızıstan"),
            new Translation(LanguageCode.BE, "Кыргызстан"),
            new Translation(LanguageCode.BG, "Киргизстан"),
            new Translation(LanguageCode.BS, "Kirgistan"),
            new Translation(LanguageCode.CA, "Kirguizistan"),
            new Translation(LanguageCode.CS, "Kyrgyzstán"),
            new Translation(LanguageCode.DA, "Kirgisistan"),
            new Translation(LanguageCode.DE, "Kirgisistan"),
            new Translation(LanguageCode.EL, "Κιργιζία"),
            new Translation(LanguageCode.EN, "Kyrgyzstan"),
            new Translation(LanguageCode.ES, "Kirguistán"),
            new Translation(LanguageCode.ET, "Kõrgõzstan"),
            new Translation(LanguageCode.FA, "قرقیزستان"),
            new Translation(LanguageCode.FI, "Kirgisia"),
            new Translation(LanguageCode.FR, "Kirghistan"),
            new Translation(LanguageCode.HE, "קירגיזסטן"),
            new Translation(LanguageCode.HR, "Kirgistan"),
            new Translation(LanguageCode.HU, "Kirgizisztán"),
            new Translation(LanguageCode.HY, "Ղրղզստան"),
            new Translation(LanguageCode.ID, "Kyrgyzstan"),
            new Translation(LanguageCode.IT, "Kirghizistan"),
            new Translation(LanguageCode.JA, "キルギス"),
            new Translation(LanguageCode.KA, "ყირგიზეთი"),
            new Translation(LanguageCode.KK, "Қырғызстан"),
            new Translation(LanguageCode.KO, "키르기즈스탄"),
            new Translation(LanguageCode.KY, "Кыргызстан"),
            new Translation(LanguageCode.LT, "Kirgizija"),
            new Translation(LanguageCode.LV, "Kirgizstāna"),
            new Translation(LanguageCode.MK, "Киргистан"),
            new Translation(LanguageCode.MN, "Кыргызстан"),
            new Translation(LanguageCode.NB, "Kirgisistan"),
            new Translation(LanguageCode.NL, "Kirgizstan"),
            new Translation(LanguageCode.NN, "Kirgisistan"),
            new Translation(LanguageCode.PL, "Kirgistan"),
            new Translation(LanguageCode.PT, "Quirguistão"),
            new Translation(LanguageCode.RO, "Kârgâzstan"),
            new Translation(LanguageCode.RU, "Киргизия"),
            new Translation(LanguageCode.SK, "Kirgizsko"),
            new Translation(LanguageCode.SL, "Kirgizistan"),
            new Translation(LanguageCode.SR, "Киргистан"),
            new Translation(LanguageCode.SV, "Kirgizistan"),
            new Translation(LanguageCode.TR, "Kırgızistan"),
            new Translation(LanguageCode.UK, "Киргизстан"),
            new Translation(LanguageCode.UZ, "Qirgʻiziston"),
            new Translation(LanguageCode.ZH, "吉尔吉斯斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KG;
        public Alpha3Code Alpha3Code => Alpha3Code.KGZ;
        public int NumericCode => 417;
        public string[] TLD => new [] { ".kg" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KZ,
            Alpha2Code.TJ,
            Alpha2Code.UZ,
        };

        public string[] Currencies => new [] { "KGS" };
        public string[] CallingCodes => new [] { "996" };
    }
}
