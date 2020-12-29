using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uganda
    /// </summary>
    public class UgandaInfo : ICountryInfo
    {
        public string CommonName => "Uganda";
        public string OfficialName => "Republic of Uganda";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أوغندا"),
            new Translation(LanguageCode.AZ, "Uqanda"),
            new Translation(LanguageCode.BE, "Уганда"),
            new Translation(LanguageCode.BG, "Уганда"),
            new Translation(LanguageCode.BS, "Uganda"),
            new Translation(LanguageCode.CA, "Uganda"),
            new Translation(LanguageCode.CS, "Uganda"),
            new Translation(LanguageCode.DA, "Uganda"),
            new Translation(LanguageCode.DE, "Uganda"),
            new Translation(LanguageCode.EL, "Ουγκάντα"),
            new Translation(LanguageCode.EN, "Uganda"),
            new Translation(LanguageCode.ES, "Uganda"),
            new Translation(LanguageCode.ET, "Uganda"),
            new Translation(LanguageCode.FA, "اوگاندا"),
            new Translation(LanguageCode.FI, "Uganda"),
            new Translation(LanguageCode.FR, "Ouganda"),
            new Translation(LanguageCode.HE, "אוגנדה"),
            new Translation(LanguageCode.HR, "Uganda"),
            new Translation(LanguageCode.HU, "Uganda"),
            new Translation(LanguageCode.HY, "Ուգանդա"),
            new Translation(LanguageCode.ID, "Uganda"),
            new Translation(LanguageCode.IT, "Uganda"),
            new Translation(LanguageCode.JA, "ウガンダ"),
            new Translation(LanguageCode.KA, "უგანდა"),
            new Translation(LanguageCode.KK, "Уганда"),
            new Translation(LanguageCode.KO, "우간다"),
            new Translation(LanguageCode.KY, "Уганда"),
            new Translation(LanguageCode.LT, "Uganda"),
            new Translation(LanguageCode.LV, "Uganda"),
            new Translation(LanguageCode.MK, "Уганда"),
            new Translation(LanguageCode.MN, "Уганда"),
            new Translation(LanguageCode.NB, "Uganda"),
            new Translation(LanguageCode.NL, "Oeganda"),
            new Translation(LanguageCode.NN, "Uganda"),
            new Translation(LanguageCode.PL, "Uganda"),
            new Translation(LanguageCode.PT, "Uganda"),
            new Translation(LanguageCode.RO, "Uganda"),
            new Translation(LanguageCode.RU, "Уганда"),
            new Translation(LanguageCode.SK, "Uganda"),
            new Translation(LanguageCode.SL, "Uganda"),
            new Translation(LanguageCode.SR, "Уганда"),
            new Translation(LanguageCode.SV, "Uganda"),
            new Translation(LanguageCode.TR, "Uganda"),
            new Translation(LanguageCode.UK, "Уганда"),
            new Translation(LanguageCode.UZ, "Uganda"),
            new Translation(LanguageCode.ZH, "乌干达"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.UG;
        public Alpha3Code Alpha3Code => Alpha3Code.UGA;
        public int NumericCode => 800;
        public string[] TLD => new [] { ".ug" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.RW,
            Alpha2Code.SS,
            Alpha2Code.TZ,
        };

        public ICurrency[] Currencies => new [] { new UgxCurrency() };
        public string[] CallingCodes => new [] { "256" };
    }
}
