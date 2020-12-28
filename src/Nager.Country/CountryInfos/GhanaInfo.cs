using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ghana
    /// </summary>
    public class GhanaInfo : ICountryInfo
    {
        public string CommonName => "Ghana";
        public string OfficialName => "Republic of Ghana";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غانا"),
            new Translation(LanguageCode.AZ, "Qana"),
            new Translation(LanguageCode.BE, "Гана"),
            new Translation(LanguageCode.BG, "Гана"),
            new Translation(LanguageCode.BS, "Gana"),
            new Translation(LanguageCode.CA, "Ghana"),
            new Translation(LanguageCode.CS, "Ghana"),
            new Translation(LanguageCode.DA, "Ghana"),
            new Translation(LanguageCode.DE, "Ghana"),
            new Translation(LanguageCode.EL, "Γκάνα"),
            new Translation(LanguageCode.EN, "Ghana"),
            new Translation(LanguageCode.ES, "Ghana"),
            new Translation(LanguageCode.ET, "Ghana"),
            new Translation(LanguageCode.FA, "غنا"),
            new Translation(LanguageCode.FI, "Ghana"),
            new Translation(LanguageCode.FR, "Ghana"),
            new Translation(LanguageCode.HE, "גאנה"),
            new Translation(LanguageCode.HR, "Gana"),
            new Translation(LanguageCode.HU, "Ghána"),
            new Translation(LanguageCode.HY, "Գանա"),
            new Translation(LanguageCode.ID, "Ghana"),
            new Translation(LanguageCode.IT, "Ghana"),
            new Translation(LanguageCode.JA, "ガーナ"),
            new Translation(LanguageCode.KA, "განა"),
            new Translation(LanguageCode.KK, "Гана"),
            new Translation(LanguageCode.KO, "가나"),
            new Translation(LanguageCode.KY, "Гана"),
            new Translation(LanguageCode.LT, "Gana"),
            new Translation(LanguageCode.LV, "Gana"),
            new Translation(LanguageCode.MK, "Гана"),
            new Translation(LanguageCode.MN, "Гана"),
            new Translation(LanguageCode.NB, "Ghana"),
            new Translation(LanguageCode.NL, "Ghana"),
            new Translation(LanguageCode.NN, "Ghana"),
            new Translation(LanguageCode.PL, "Ghana"),
            new Translation(LanguageCode.PT, "Gana"),
            new Translation(LanguageCode.RO, "Ghana"),
            new Translation(LanguageCode.RU, "Гана"),
            new Translation(LanguageCode.SK, "Ghana"),
            new Translation(LanguageCode.SL, "Gana"),
            new Translation(LanguageCode.SR, "Гана"),
            new Translation(LanguageCode.SV, "Ghana"),
            new Translation(LanguageCode.TR, "Gana"),
            new Translation(LanguageCode.UK, "Гана"),
            new Translation(LanguageCode.UZ, "Gana"),
            new Translation(LanguageCode.ZH, "加纳"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GH;
        public Alpha3Code Alpha3Code => Alpha3Code.GHA;
        public int NumericCode => 288;
        public string[] TLD => new [] { ".gh" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.CI,
            Alpha2Code.TG,
        };

        public ICurrency[] Currencies => new [] { new GhsCurrency() };
        public string[] CallingCodes => new [] { "233" };
    }
}
