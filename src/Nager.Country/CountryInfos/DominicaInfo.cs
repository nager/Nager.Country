namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominica
    /// </summary>
    public class DominicaInfo : ICountryInfo
    {
        public string CommonName => "Dominica";
        public string OfficialName => "Commonwealth of Dominica";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "دومينيكا"),
            new Translation(LanguageCode.AZ, "Dominika"),
            new Translation(LanguageCode.BE, "Дамініка"),
            new Translation(LanguageCode.BG, "Доминика"),
            new Translation(LanguageCode.BS, "Dominika"),
            new Translation(LanguageCode.CA, "Dominica"),
            new Translation(LanguageCode.CS, "Dominika"),
            new Translation(LanguageCode.DA, "Dominica"),
            new Translation(LanguageCode.DE, "Dominica"),
            new Translation(LanguageCode.EL, "Κοινοπολιτεία της Δομινίκας"),
            new Translation(LanguageCode.EN, "Dominica"),
            new Translation(LanguageCode.ES, "Dominica"),
            new Translation(LanguageCode.ET, "Dominica"),
            new Translation(LanguageCode.FA, "دومینیکا"),
            new Translation(LanguageCode.FI, "Dominica"),
            new Translation(LanguageCode.FR, "Dominique"),
            new Translation(LanguageCode.HE, "דומיניקה"),
            new Translation(LanguageCode.HR, "Dominika"),
            new Translation(LanguageCode.HU, "Dominikai Közösség"),
            new Translation(LanguageCode.HY, "Դոմինիկա"),
            new Translation(LanguageCode.ID, "Dominika"),
            new Translation(LanguageCode.IT, "Dominica"),
            new Translation(LanguageCode.JA, "ドミニカ国"),
            new Translation(LanguageCode.KA, "დომინიკა"),
            new Translation(LanguageCode.KK, "Доминика"),
            new Translation(LanguageCode.KO, "도미니카 공화국"),
            new Translation(LanguageCode.KY, "Доминика"),
            new Translation(LanguageCode.LT, "Dominika"),
            new Translation(LanguageCode.LV, "Dominika"),
            new Translation(LanguageCode.MK, "Доминика"),
            new Translation(LanguageCode.MN, "Доминик"),
            new Translation(LanguageCode.NB, "Dominica"),
            new Translation(LanguageCode.NL, "Dominica"),
            new Translation(LanguageCode.NN, "Dominica"),
            new Translation(LanguageCode.PL, "Dominika"),
            new Translation(LanguageCode.PT, "Dominica"),
            new Translation(LanguageCode.RO, "Dominica"),
            new Translation(LanguageCode.RU, "Доминика"),
            new Translation(LanguageCode.SK, "Dominika"),
            new Translation(LanguageCode.SL, "Dominika"),
            new Translation(LanguageCode.SR, "Доминика"),
            new Translation(LanguageCode.SV, "Dominica"),
            new Translation(LanguageCode.TR, "Dominika"),
            new Translation(LanguageCode.UK, "Домініка"),
            new Translation(LanguageCode.UZ, "Dominika"),
            new Translation(LanguageCode.ZH, "多米尼克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.DM;
        public Alpha3Code Alpha3Code => Alpha3Code.DMA;
        public int NumericCode => 212;
        public string[] TLD => new [] { ".dm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "XCD" };
        public string[] CallingCodes => new [] { "1767" };
    }
}
