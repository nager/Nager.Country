using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Panama
    /// </summary>
    public class PanamaInfo : ICountryInfo
    {
        public string CommonName => "Panama";
        public string OfficialName => "Republic of Panama";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بنما"),
            new Translation(LanguageCode.AZ, "Panama"),
            new Translation(LanguageCode.BE, "Панама"),
            new Translation(LanguageCode.BG, "Панама"),
            new Translation(LanguageCode.BS, "Panama"),
            new Translation(LanguageCode.CA, "Panamà"),
            new Translation(LanguageCode.CS, "Panama"),
            new Translation(LanguageCode.DA, "Panama"),
            new Translation(LanguageCode.DE, "Panama"),
            new Translation(LanguageCode.EL, "Παναμάς"),
            new Translation(LanguageCode.EN, "Panama"),
            new Translation(LanguageCode.ES, "Panamá"),
            new Translation(LanguageCode.ET, "Panama"),
            new Translation(LanguageCode.FA, "پاناما"),
            new Translation(LanguageCode.FI, "Panama"),
            new Translation(LanguageCode.FR, "Panama"),
            new Translation(LanguageCode.HE, "פנמה"),
            new Translation(LanguageCode.HR, "Panama"),
            new Translation(LanguageCode.HU, "Panama"),
            new Translation(LanguageCode.HY, "Պանամա"),
            new Translation(LanguageCode.ID, "Panama"),
            new Translation(LanguageCode.IT, "Panamá"),
            new Translation(LanguageCode.JA, "パナマ"),
            new Translation(LanguageCode.KA, "პანამა"),
            new Translation(LanguageCode.KK, "Панама"),
            new Translation(LanguageCode.KO, "파나마"),
            new Translation(LanguageCode.KY, "Панама"),
            new Translation(LanguageCode.LT, "Panama"),
            new Translation(LanguageCode.LV, "Panama"),
            new Translation(LanguageCode.MK, "Панама"),
            new Translation(LanguageCode.MN, "Панам"),
            new Translation(LanguageCode.NB, "Panama"),
            new Translation(LanguageCode.NL, "Panama"),
            new Translation(LanguageCode.NN, "Panama"),
            new Translation(LanguageCode.PL, "Panama"),
            new Translation(LanguageCode.PT, "Panamá"),
            new Translation(LanguageCode.RO, "Panama"),
            new Translation(LanguageCode.RU, "Панама"),
            new Translation(LanguageCode.SK, "Panama"),
            new Translation(LanguageCode.SL, "Panama"),
            new Translation(LanguageCode.SR, "Панама"),
            new Translation(LanguageCode.SV, "Panama"),
            new Translation(LanguageCode.TR, "Panama"),
            new Translation(LanguageCode.UK, "Панама"),
            new Translation(LanguageCode.UZ, "Panama"),
            new Translation(LanguageCode.ZH, "巴拿马"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PA;
        public Alpha3Code Alpha3Code => Alpha3Code.PAN;
        public int NumericCode => 591;
        public string[] TLD => new [] { ".pa" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CO,
            Alpha2Code.CR,
        };

        public ICurrency[] Currencies => new ICurrency[] { new PabCurrency(), new UsdCurrency() };
        public string[] CallingCodes => new [] { "507" };
    }
}
