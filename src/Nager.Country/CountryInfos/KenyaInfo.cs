using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kenya
    /// </summary>
    public class KenyaInfo : ICountryInfo
    {
        public string CommonName => "Kenya";
        public string OfficialName => "Republic of Kenya";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كينيا"),
            new Translation(LanguageCode.AZ, "Keniya"),
            new Translation(LanguageCode.BE, "Кенія"),
            new Translation(LanguageCode.BG, "Кения"),
            new Translation(LanguageCode.BS, "Kenija"),
            new Translation(LanguageCode.CA, "Kenya"),
            new Translation(LanguageCode.CS, "Keňa"),
            new Translation(LanguageCode.DA, "Kenya"),
            new Translation(LanguageCode.DE, "Kenia"),
            new Translation(LanguageCode.EL, "Κένυα"),
            new Translation(LanguageCode.EN, "Kenya"),
            new Translation(LanguageCode.ES, "Kenya"),
            new Translation(LanguageCode.ET, "Kenya"),
            new Translation(LanguageCode.FA, "کنیا"),
            new Translation(LanguageCode.FI, "Kenia"),
            new Translation(LanguageCode.FR, "Kenya"),
            new Translation(LanguageCode.HE, "קניה"),
            new Translation(LanguageCode.HR, "Kenija"),
            new Translation(LanguageCode.HU, "Kenya"),
            new Translation(LanguageCode.HY, "Քենիա"),
            new Translation(LanguageCode.ID, "Kenya"),
            new Translation(LanguageCode.IT, "Kenya"),
            new Translation(LanguageCode.JA, "ケニア"),
            new Translation(LanguageCode.KA, "კენია"),
            new Translation(LanguageCode.KK, "Кения"),
            new Translation(LanguageCode.KO, "케냐"),
            new Translation(LanguageCode.KY, "Кения"),
            new Translation(LanguageCode.LT, "Kenija"),
            new Translation(LanguageCode.LV, "Kenija"),
            new Translation(LanguageCode.MK, "Кенија"),
            new Translation(LanguageCode.MN, "Кени"),
            new Translation(LanguageCode.NB, "Kenya"),
            new Translation(LanguageCode.NL, "Kenia"),
            new Translation(LanguageCode.NN, "Kenya"),
            new Translation(LanguageCode.PL, "Kenia"),
            new Translation(LanguageCode.PT, "Quênia"),
            new Translation(LanguageCode.RO, "Kenya"),
            new Translation(LanguageCode.RU, "Кения"),
            new Translation(LanguageCode.SK, "Keňa"),
            new Translation(LanguageCode.SL, "Kenija"),
            new Translation(LanguageCode.SR, "Кенија"),
            new Translation(LanguageCode.SV, "Kenya"),
            new Translation(LanguageCode.TR, "Kenya"),
            new Translation(LanguageCode.UK, "Кенія"),
            new Translation(LanguageCode.UZ, "Keniya"),
            new Translation(LanguageCode.ZH, "肯尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KE;
        public Alpha3Code Alpha3Code => Alpha3Code.KEN;
        public int NumericCode => 404;
        public string[] TLD => new [] { ".ke" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ET,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        };

        public ICurrency[] Currencies => new [] { new KesCurrency() };
        public string[] CallingCodes => new [] { "254" };
    }
}
