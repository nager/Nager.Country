using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cayman Islands
    /// </summary>
    public class CaymanIslandsInfo : ICountryInfo
    {
        public string CommonName => "Cayman Islands";
        public string OfficialName => "Cayman Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر كايمان"),
            new Translation(LanguageCode.AZ, "Kayman adaları"),
            new Translation(LanguageCode.BE, "Кайманавы астравы"),
            new Translation(LanguageCode.BG, "Кайманови острови"),
            new Translation(LanguageCode.BS, "Kajmanska Ostrva"),
            new Translation(LanguageCode.CA, "Caiman, illes"),
            new Translation(LanguageCode.CS, "Kajmanské ostrovy"),
            new Translation(LanguageCode.DA, "Caymanøerne"),
            new Translation(LanguageCode.DE, "Kaimaninseln"),
            new Translation(LanguageCode.EL, "Κέιμαν Νήσοι"),
            new Translation(LanguageCode.EN, "Cayman Islands"),
            new Translation(LanguageCode.ES, "Islas Caimán"),
            new Translation(LanguageCode.ET, "Kaimanisaared"),
            new Translation(LanguageCode.FA, "جزایر کِیمن"),
            new Translation(LanguageCode.FI, "Caymansaaret"),
            new Translation(LanguageCode.FR, "Caïmanes"),
            new Translation(LanguageCode.HE, "איי קיימן"),
            new Translation(LanguageCode.HR, "Kajmanski otoci"),
            new Translation(LanguageCode.HU, "Kajmán-szigetek"),
            new Translation(LanguageCode.HY, "Կայմանյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Cayman"),
            new Translation(LanguageCode.IT, "Isole Cayman"),
            new Translation(LanguageCode.JA, "ケイマン諸島"),
            new Translation(LanguageCode.KA, "კაიმანის კუნძულები"),
            new Translation(LanguageCode.KK, "Кайман аралдары"),
            new Translation(LanguageCode.KO, "케이맨 제도"),
            new Translation(LanguageCode.KY, "Кайман Аралдары"),
            new Translation(LanguageCode.LT, "Kaimanų Salos"),
            new Translation(LanguageCode.LV, "Kaimanu salas"),
            new Translation(LanguageCode.MK, "Кајмански Острови"),
            new Translation(LanguageCode.MN, "Кайманы Арлууд"),
            new Translation(LanguageCode.NB, "Caymanøyene"),
            new Translation(LanguageCode.NL, "Kaaimaneilanden"),
            new Translation(LanguageCode.NN, "Caymanøyane"),
            new Translation(LanguageCode.PL, "Kajmany"),
            new Translation(LanguageCode.PT, "Ilhas Caiman"),
            new Translation(LanguageCode.RO, "Insulele Cayman"),
            new Translation(LanguageCode.RU, "Острова Кайман"),
            new Translation(LanguageCode.SK, "Kajmanie ostrovy"),
            new Translation(LanguageCode.SL, "Kajmanski otoki"),
            new Translation(LanguageCode.SR, "Кајманска Острва"),
            new Translation(LanguageCode.SV, "Caymanöarna"),
            new Translation(LanguageCode.TR, "Cayman Adaları"),
            new Translation(LanguageCode.UK, "Кайманові Острови"),
            new Translation(LanguageCode.UZ, "Kayman orollari"),
            new Translation(LanguageCode.ZH, "开曼群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KY;
        public Alpha3Code Alpha3Code => Alpha3Code.CYM;
        public int NumericCode => 136;
        public string[] TLD => new [] { ".ky" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new KydCurrency() };
        public string[] CallingCodes => new [] { "1345" };
    }
}
