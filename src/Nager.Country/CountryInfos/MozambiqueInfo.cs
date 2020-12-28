using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mozambique
    /// </summary>
    public class MozambiqueInfo : ICountryInfo
    {
        public string CommonName => "Mozambique";
        public string OfficialName => "Republic of Mozambique";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "موزمبيق"),
            new Translation(LanguageCode.AZ, "Mozambik"),
            new Translation(LanguageCode.BE, "Мазамбік"),
            new Translation(LanguageCode.BG, "Мозамбик"),
            new Translation(LanguageCode.BS, "Mozambik"),
            new Translation(LanguageCode.CA, "Moçambic"),
            new Translation(LanguageCode.CS, "Mosambik"),
            new Translation(LanguageCode.DA, "Mozambique"),
            new Translation(LanguageCode.DE, "Mosambik"),
            new Translation(LanguageCode.EL, "Μοζαμβίκη"),
            new Translation(LanguageCode.EN, "Mozambique"),
            new Translation(LanguageCode.ES, "Mozambique"),
            new Translation(LanguageCode.ET, "Mosambiik"),
            new Translation(LanguageCode.FA, "موزامبیک"),
            new Translation(LanguageCode.FI, "Mosambik"),
            new Translation(LanguageCode.FR, "Mozambique"),
            new Translation(LanguageCode.HE, "מוזמביק"),
            new Translation(LanguageCode.HR, "Mozambik"),
            new Translation(LanguageCode.HU, "Mozambik"),
            new Translation(LanguageCode.HY, "Մոզամբիկ"),
            new Translation(LanguageCode.ID, "Mozambik"),
            new Translation(LanguageCode.IT, "Mozambico"),
            new Translation(LanguageCode.JA, "モザンビーク"),
            new Translation(LanguageCode.KA, "მოზამბიკი"),
            new Translation(LanguageCode.KK, "Мозамбик"),
            new Translation(LanguageCode.KO, "모잠비크"),
            new Translation(LanguageCode.KY, "Мозамбик"),
            new Translation(LanguageCode.LT, "Mozambikas"),
            new Translation(LanguageCode.LV, "Mozambika"),
            new Translation(LanguageCode.MK, "Мозамбик"),
            new Translation(LanguageCode.MN, "Мозамбик"),
            new Translation(LanguageCode.NB, "Mosambik"),
            new Translation(LanguageCode.NL, "Mozambique"),
            new Translation(LanguageCode.NN, "Mosambik"),
            new Translation(LanguageCode.PL, "Mozambik"),
            new Translation(LanguageCode.PT, "Moçambique"),
            new Translation(LanguageCode.RO, "Mozambic"),
            new Translation(LanguageCode.RU, "Мозамбик"),
            new Translation(LanguageCode.SK, "Mozambik"),
            new Translation(LanguageCode.SL, "Mozambik"),
            new Translation(LanguageCode.SR, "Мозамбик"),
            new Translation(LanguageCode.SV, "Moçambique"),
            new Translation(LanguageCode.TR, "Mozambik"),
            new Translation(LanguageCode.UK, "Мозамбік"),
            new Translation(LanguageCode.UZ, "Mozambik"),
            new Translation(LanguageCode.ZH, "莫桑比克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MZ;
        public Alpha3Code Alpha3Code => Alpha3Code.MOZ;
        public int NumericCode => 508;
        public string[] TLD => new [] { ".mz" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.MW,
            Alpha2Code.ZA,
            Alpha2Code.SZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
            Alpha2Code.ZW,
        };

        public ICurrency[] Currencies => new [] { new MznCurrency() };
        public string[] CallingCodes => new [] { "258" };
    }
}
