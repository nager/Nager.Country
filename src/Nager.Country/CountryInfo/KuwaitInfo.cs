namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Kuwait
    /// </summary>
    public class KuwaitInfo : ICountryInfo
    {
        public string CommonName => "Kuwait";
        public string OfficialName => "State of Kuwait";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الكويت"),
            new Translation(LanguageCode.AZ, "Küveyt"),
            new Translation(LanguageCode.BE, "Кувейт"),
            new Translation(LanguageCode.BG, "Кувейт"),
            new Translation(LanguageCode.BS, "Kuvajt"),
            new Translation(LanguageCode.CA, "Kuwait"),
            new Translation(LanguageCode.CS, "Kuvajt"),
            new Translation(LanguageCode.DA, "Kuwait"),
            new Translation(LanguageCode.DE, "Kuwait"),
            new Translation(LanguageCode.EL, "Κουβέιτ"),
            new Translation(LanguageCode.EN, "Kuwait"),
            new Translation(LanguageCode.ES, "Kuwait"),
            new Translation(LanguageCode.ET, "Kuveit"),
            new Translation(LanguageCode.FA, "کویت"),
            new Translation(LanguageCode.FI, "Kuwait"),
            new Translation(LanguageCode.FR, "Koweit"),
            new Translation(LanguageCode.HE, "כווית"),
            new Translation(LanguageCode.HR, "Kuvajt"),
            new Translation(LanguageCode.HU, "Kuvait"),
            new Translation(LanguageCode.HY, "Քուվեյթ"),
            new Translation(LanguageCode.ID, "Kuwait"),
            new Translation(LanguageCode.IT, "Kuwait"),
            new Translation(LanguageCode.JA, "クウェート"),
            new Translation(LanguageCode.KA, "ქუვეითი"),
            new Translation(LanguageCode.KK, "Кувейт"),
            new Translation(LanguageCode.KO, "쿠웨이트"),
            new Translation(LanguageCode.KY, "Кувейт"),
            new Translation(LanguageCode.LT, "Kuveitas"),
            new Translation(LanguageCode.LV, "Kuveita"),
            new Translation(LanguageCode.MK, "Кувајт"),
            new Translation(LanguageCode.MN, "Кувейт"),
            new Translation(LanguageCode.NB, "Kuwait"),
            new Translation(LanguageCode.NL, "Koeweit"),
            new Translation(LanguageCode.NN, "Kuwait"),
            new Translation(LanguageCode.PL, "Kuwejt"),
            new Translation(LanguageCode.PT, "Kuwait"),
            new Translation(LanguageCode.RO, "Kuweit"),
            new Translation(LanguageCode.RU, "Кувейт"),
            new Translation(LanguageCode.SK, "Kuvajt"),
            new Translation(LanguageCode.SL, "Kuvajt"),
            new Translation(LanguageCode.SR, "Кувајт"),
            new Translation(LanguageCode.SV, "Kuwait"),
            new Translation(LanguageCode.TR, "Kuveyt"),
            new Translation(LanguageCode.UK, "Кувейт"),
            new Translation(LanguageCode.UZ, "Quvayt"),
            new Translation(LanguageCode.ZH, "科威特"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KW;
        public Alpha3Code Alpha3Code => Alpha3Code.KWT;
        public int NumericCode => 414;
        public string[] TLD => new [] { ".kw" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.SA,
        };

        public string[] Currencies => new [] { "KWD" };
        public string[] CallingCodes => new [] { "965" };
    }
}
