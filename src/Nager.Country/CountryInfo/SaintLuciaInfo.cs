namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Saint Lucia
    /// </summary>
    public class SaintLuciaInfo : ICountryInfo
    {
        public string CommonName => "Saint Lucia";
        public string OfficialName => "Saint Lucia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سانت لوسيا"),
            new Translation(LanguageCode.AZ, "Sent-Lusiya"),
            new Translation(LanguageCode.BE, "Сент-Люсія"),
            new Translation(LanguageCode.BG, "Сейнт Лусия"),
            new Translation(LanguageCode.BS, "Sveta Lucija"),
            new Translation(LanguageCode.CA, "Saint Lucia"),
            new Translation(LanguageCode.CS, "Svatá Lucie"),
            new Translation(LanguageCode.DA, "Saint Lucia"),
            new Translation(LanguageCode.DE, "St. Lucia"),
            new Translation(LanguageCode.EL, "Αγία Λουκία"),
            new Translation(LanguageCode.EN, "Saint Lucia"),
            new Translation(LanguageCode.ES, "Santa Lucía"),
            new Translation(LanguageCode.ET, "Saint Lucia"),
            new Translation(LanguageCode.FA, "سنت لوسیا"),
            new Translation(LanguageCode.FI, "Saint Lucia"),
            new Translation(LanguageCode.FR, "Sainte-Lucie"),
            new Translation(LanguageCode.HE, "סנט לוסיה"),
            new Translation(LanguageCode.HR, "Sveta Lucija"),
            new Translation(LanguageCode.HU, "Saint Lucia"),
            new Translation(LanguageCode.HY, "Սենթ Լյուսիա"),
            new Translation(LanguageCode.ID, "Saint Lucia"),
            new Translation(LanguageCode.IT, "Santa Lucia"),
            new Translation(LanguageCode.JA, "セントルシア"),
            new Translation(LanguageCode.KA, "სენტ-ლუსია"),
            new Translation(LanguageCode.KK, "Сент-Люсия"),
            new Translation(LanguageCode.KO, "세인트 루시아"),
            new Translation(LanguageCode.KY, "Сент-Люсия"),
            new Translation(LanguageCode.LT, "Sent Lusija"),
            new Translation(LanguageCode.LV, "Sentlūsija"),
            new Translation(LanguageCode.MK, "Света Луција"),
            new Translation(LanguageCode.MN, "Сент Люсиа"),
            new Translation(LanguageCode.NB, "Saint Lucia"),
            new Translation(LanguageCode.NL, "Saint Lucia"),
            new Translation(LanguageCode.NN, "Saint Lucia"),
            new Translation(LanguageCode.PL, "Saint Lucia"),
            new Translation(LanguageCode.PT, "Santa Lúcia"),
            new Translation(LanguageCode.RO, "Sfânta Lucia"),
            new Translation(LanguageCode.RU, "Сент-Люсия"),
            new Translation(LanguageCode.SK, "Svätá Lucia"),
            new Translation(LanguageCode.SL, "Saint Lucia"),
            new Translation(LanguageCode.SR, "Света Луција"),
            new Translation(LanguageCode.SV, "Saint Lucia"),
            new Translation(LanguageCode.TR, "Saint Lucia"),
            new Translation(LanguageCode.UK, "Сент-Люсія"),
            new Translation(LanguageCode.UZ, "Sent-Lyusiya"),
            new Translation(LanguageCode.ZH, "圣卢西亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LC;
        public Alpha3Code Alpha3Code => Alpha3Code.LCA;
        public int NumericCode => 662;
        public string[] TLD => new [] { ".lc" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "XCD" };
        public string[] CallingCodes => new [] { "1758" };
    }
}
