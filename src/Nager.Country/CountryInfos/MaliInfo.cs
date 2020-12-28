using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mali
    /// </summary>
    public class MaliInfo : ICountryInfo
    {
        public string CommonName => "Mali";
        public string OfficialName => "Republic of Mali";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مالي"),
            new Translation(LanguageCode.AZ, "Mali"),
            new Translation(LanguageCode.BE, "Малі"),
            new Translation(LanguageCode.BG, "Мали"),
            new Translation(LanguageCode.BS, "Mali"),
            new Translation(LanguageCode.CA, "Mali"),
            new Translation(LanguageCode.CS, "Mali"),
            new Translation(LanguageCode.DA, "Mali"),
            new Translation(LanguageCode.DE, "Mali"),
            new Translation(LanguageCode.EL, "Μαλί"),
            new Translation(LanguageCode.EN, "Mali"),
            new Translation(LanguageCode.ES, "Malí"),
            new Translation(LanguageCode.ET, "Mali"),
            new Translation(LanguageCode.FA, "مالی"),
            new Translation(LanguageCode.FI, "Mali"),
            new Translation(LanguageCode.FR, "Mali"),
            new Translation(LanguageCode.HE, "מאלי"),
            new Translation(LanguageCode.HR, "Mali"),
            new Translation(LanguageCode.HU, "Mali"),
            new Translation(LanguageCode.HY, "Մալի"),
            new Translation(LanguageCode.ID, "Mali"),
            new Translation(LanguageCode.IT, "Mali"),
            new Translation(LanguageCode.JA, "マリ"),
            new Translation(LanguageCode.KA, "მალი"),
            new Translation(LanguageCode.KK, "Мали"),
            new Translation(LanguageCode.KO, "말리"),
            new Translation(LanguageCode.KY, "Мали"),
            new Translation(LanguageCode.LT, "Malis"),
            new Translation(LanguageCode.LV, "Mali"),
            new Translation(LanguageCode.MK, "Мали"),
            new Translation(LanguageCode.MN, "Мали"),
            new Translation(LanguageCode.NB, "Mali"),
            new Translation(LanguageCode.NL, "Mali"),
            new Translation(LanguageCode.NN, "Mali"),
            new Translation(LanguageCode.PL, "Mali"),
            new Translation(LanguageCode.PT, "Mali"),
            new Translation(LanguageCode.RO, "Mali"),
            new Translation(LanguageCode.RU, "Мали"),
            new Translation(LanguageCode.SK, "Mali"),
            new Translation(LanguageCode.SL, "Mali"),
            new Translation(LanguageCode.SR, "Мали"),
            new Translation(LanguageCode.SV, "Mali"),
            new Translation(LanguageCode.TR, "Mali"),
            new Translation(LanguageCode.UK, "Малі"),
            new Translation(LanguageCode.UZ, "Mali"),
            new Translation(LanguageCode.ZH, "马里"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ML;
        public Alpha3Code Alpha3Code => Alpha3Code.MLI;
        public int NumericCode => 466;
        public string[] TLD => new [] { ".ml" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.BF,
            Alpha2Code.GN,
            Alpha2Code.CI,
            Alpha2Code.MR,
            Alpha2Code.NE,
            Alpha2Code.SN,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "223" };
    }
}
