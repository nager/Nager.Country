namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uruguay
    /// </summary>
    public class UruguayInfo : ICountryInfo
    {
        public string CommonName => "Uruguay";
        public string OfficialName => "Oriental Republic of Uruguay";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الأوروغواي"),
            new Translation(LanguageCode.AZ, "Uruqvay"),
            new Translation(LanguageCode.BE, "Уругвай"),
            new Translation(LanguageCode.BG, "Уругвай"),
            new Translation(LanguageCode.BS, "Urugvaj"),
            new Translation(LanguageCode.CA, "Uruguai"),
            new Translation(LanguageCode.CS, "Uruguay"),
            new Translation(LanguageCode.DA, "Uruguay"),
            new Translation(LanguageCode.DE, "Uruguay"),
            new Translation(LanguageCode.EL, "Ουρουγουάη"),
            new Translation(LanguageCode.EN, "Uruguay"),
            new Translation(LanguageCode.ES, "Uruguay"),
            new Translation(LanguageCode.ET, "Uruguay"),
            new Translation(LanguageCode.FA, "اروگوئه"),
            new Translation(LanguageCode.FI, "Uruguay"),
            new Translation(LanguageCode.FR, "Uruguay"),
            new Translation(LanguageCode.HE, "אורוגוואי"),
            new Translation(LanguageCode.HR, "Urugvaj"),
            new Translation(LanguageCode.HU, "Uruguay"),
            new Translation(LanguageCode.HY, "Ուրուգվայ"),
            new Translation(LanguageCode.ID, "Uruguay"),
            new Translation(LanguageCode.IT, "Uruguay"),
            new Translation(LanguageCode.JA, "ウルグアイ"),
            new Translation(LanguageCode.KA, "ურუგვაი"),
            new Translation(LanguageCode.KK, "Уругвай"),
            new Translation(LanguageCode.KO, "우루과이"),
            new Translation(LanguageCode.KY, "Уругвай"),
            new Translation(LanguageCode.LT, "Urugvajus"),
            new Translation(LanguageCode.LV, "Urugvaja"),
            new Translation(LanguageCode.MK, "Уругвај"),
            new Translation(LanguageCode.MN, "Уругвай"),
            new Translation(LanguageCode.NB, "Uruguay"),
            new Translation(LanguageCode.NL, "Uruguay"),
            new Translation(LanguageCode.NN, "Uruguay"),
            new Translation(LanguageCode.PL, "Urugwaj"),
            new Translation(LanguageCode.PT, "Uruguai"),
            new Translation(LanguageCode.RO, "Uruguay"),
            new Translation(LanguageCode.RU, "Уругвай"),
            new Translation(LanguageCode.SK, "Uruguaj"),
            new Translation(LanguageCode.SL, "Urugvaj"),
            new Translation(LanguageCode.SR, "Уругвај"),
            new Translation(LanguageCode.SV, "Uruguay"),
            new Translation(LanguageCode.TR, "Uruguay"),
            new Translation(LanguageCode.UK, "Уругвай"),
            new Translation(LanguageCode.UZ, "Urugvay"),
            new Translation(LanguageCode.ZH, "乌拉圭"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.UY;
        public Alpha3Code Alpha3Code => Alpha3Code.URY;
        public int NumericCode => 858;
        public string[] TLD => new [] { ".uy" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
        };

        public string[] Currencies => new [] { "UYU" };
        public string[] CallingCodes => new [] { "598" };
    }
}
