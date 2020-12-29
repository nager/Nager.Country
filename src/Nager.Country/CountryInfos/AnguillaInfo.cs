using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Anguilla
    /// </summary>
    public class AnguillaInfo : ICountryInfo
    {
        public string CommonName => "Anguilla";
        public string OfficialName => "Anguilla";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أنغويلا"),
            new Translation(LanguageCode.AZ, "Angilya"),
            new Translation(LanguageCode.BE, "Ангілья"),
            new Translation(LanguageCode.BG, "Ангуила"),
            new Translation(LanguageCode.BS, "Angvila"),
            new Translation(LanguageCode.CA, "Anguilla"),
            new Translation(LanguageCode.CS, "Anguilla"),
            new Translation(LanguageCode.DA, "Anguilla"),
            new Translation(LanguageCode.DE, "Anguilla"),
            new Translation(LanguageCode.EL, "Ανγκουίλα"),
            new Translation(LanguageCode.EN, "Anguilla"),
            new Translation(LanguageCode.ES, "Anguila"),
            new Translation(LanguageCode.ET, "Anguilla"),
            new Translation(LanguageCode.FA, "آنگویلا"),
            new Translation(LanguageCode.FI, "Anguilla"),
            new Translation(LanguageCode.FR, "Anguilla"),
            new Translation(LanguageCode.HE, "אנגילה"),
            new Translation(LanguageCode.HR, "Angvila"),
            new Translation(LanguageCode.HU, "Anguilla"),
            new Translation(LanguageCode.HY, "Անգուիլա"),
            new Translation(LanguageCode.ID, "Anguilla"),
            new Translation(LanguageCode.IT, "Anguilla"),
            new Translation(LanguageCode.JA, "アンギラ"),
            new Translation(LanguageCode.KA, "ანგვილა"),
            new Translation(LanguageCode.KK, "Ангилья"),
            new Translation(LanguageCode.KO, "앵 귈라"),
            new Translation(LanguageCode.KY, "Ангуила"),
            new Translation(LanguageCode.LT, "Angilija"),
            new Translation(LanguageCode.LV, "Angilja"),
            new Translation(LanguageCode.MK, "Ангвила"),
            new Translation(LanguageCode.MN, "Ангила"),
            new Translation(LanguageCode.NB, "Anguilla"),
            new Translation(LanguageCode.NL, "Anguilla"),
            new Translation(LanguageCode.NN, "Anguilla"),
            new Translation(LanguageCode.PL, "Anguilla"),
            new Translation(LanguageCode.PT, "Anguilla"),
            new Translation(LanguageCode.RO, "Anguilla"),
            new Translation(LanguageCode.RU, "Ангилья"),
            new Translation(LanguageCode.SK, "Anguilla"),
            new Translation(LanguageCode.SL, "Angvila"),
            new Translation(LanguageCode.SR, "Ангвила"),
            new Translation(LanguageCode.SV, "Anguilla"),
            new Translation(LanguageCode.TR, "Anguilla"),
            new Translation(LanguageCode.UK, "Ангілья"),
            new Translation(LanguageCode.UZ, "Angilya"),
            new Translation(LanguageCode.ZH, "安圭拉"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AI;
        public Alpha3Code Alpha3Code => Alpha3Code.AIA;
        public int NumericCode => 660;
        public string[] TLD => new [] { ".ai" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1264" };
    }
}
