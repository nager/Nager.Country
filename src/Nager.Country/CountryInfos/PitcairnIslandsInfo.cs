using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Pitcairn Islands
    /// </summary>
    public class PitcairnIslandsInfo : ICountryInfo
    {
        public string CommonName => "Pitcairn Islands";
        public string OfficialName => "Pitcairn Group of Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر بيتكيرن"),
            new Translation(LanguageCode.AZ, "Pitkern adaları"),
            new Translation(LanguageCode.BE, "Астравы Піткэрн"),
            new Translation(LanguageCode.BG, "Острови Питкерн"),
            new Translation(LanguageCode.BS, "Pitkernska Ostrva"),
            new Translation(LanguageCode.CA, "Pitcairn, illes"),
            new Translation(LanguageCode.CS, "Pitcairnovy ostrovy"),
            new Translation(LanguageCode.DA, "Pitcairn"),
            new Translation(LanguageCode.DE, "Pitcairninseln"),
            new Translation(LanguageCode.EL, "Νήσοι Πίτκαιρν"),
            new Translation(LanguageCode.EN, "Pitcairn"),
            new Translation(LanguageCode.ES, "Pitcairn"),
            new Translation(LanguageCode.ET, "Pitcairn"),
            new Translation(LanguageCode.FA, "جزایر پیت‌کرن"),
            new Translation(LanguageCode.FI, "Pitcairn"),
            new Translation(LanguageCode.FR, "Pitcairn"),
            new Translation(LanguageCode.HE, "איי פיטקרן"),
            new Translation(LanguageCode.HR, "Otoci Pitcairn"),
            new Translation(LanguageCode.HU, "Pitcairn-szigetek"),
            new Translation(LanguageCode.HY, "Պիտկեռն կղզիներ"),
            new Translation(LanguageCode.ID, "Pitcairn"),
            new Translation(LanguageCode.IT, "Isole Pitcairn"),
            new Translation(LanguageCode.JA, "ピトケアン"),
            new Translation(LanguageCode.KA, "პიტკერნის კუნძულები"),
            new Translation(LanguageCode.KK, "Питкэрн аралдары"),
            new Translation(LanguageCode.KO, "핏 케언"),
            new Translation(LanguageCode.KY, "Питкэрн аралдары"),
            new Translation(LanguageCode.LT, "Pitkerno salos"),
            new Translation(LanguageCode.LV, "Pitkērnas salas"),
            new Translation(LanguageCode.MK, "Питкернски Острови"),
            new Translation(LanguageCode.MN, "Питкэрн арлууд"),
            new Translation(LanguageCode.NB, "Pitcairn"),
            new Translation(LanguageCode.NL, "Pitcairn"),
            new Translation(LanguageCode.NN, "Pitcairn"),
            new Translation(LanguageCode.PL, "Pitcairn"),
            new Translation(LanguageCode.PT, "Ilhas Pitcairn"),
            new Translation(LanguageCode.RO, "Insulele Pitcairn"),
            new Translation(LanguageCode.RU, "Острова Питкэрн"),
            new Translation(LanguageCode.SK, "Pitcairnove ostrovy"),
            new Translation(LanguageCode.SL, "Pitcairn"),
            new Translation(LanguageCode.SR, "Питкерн"),
            new Translation(LanguageCode.SV, "Pitcairnöarna"),
            new Translation(LanguageCode.TR, "Pitcairn Adaları"),
            new Translation(LanguageCode.UK, "Піткерн"),
            new Translation(LanguageCode.UZ, "Pitkern orollari"),
            new Translation(LanguageCode.ZH, "皮特凯恩群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PN;
        public Alpha3Code Alpha3Code => Alpha3Code.PCN;
        public int NumericCode => 612;
        public string[] TLD => new [] { ".pn" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "64" };
    }
}
