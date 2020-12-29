using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Wallis and Futuna
    /// </summary>
    public class WallisAndFutunaInfo : ICountryInfo
    {
        public string CommonName => "Wallis and Futuna";
        public string OfficialName => "Territory of the Wallis and Futuna Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "والس وفوتونا"),
            new Translation(LanguageCode.AZ, "Uollis və Futuna"),
            new Translation(LanguageCode.BE, "Уоліс і Футуна"),
            new Translation(LanguageCode.BG, "Уолис и Футуна"),
            new Translation(LanguageCode.BS, "Ostrva Valis i Futuna"),
            new Translation(LanguageCode.CA, "Wallis i Futuna"),
            new Translation(LanguageCode.CS, "Wallis a Futuna"),
            new Translation(LanguageCode.DA, "Wallis og Futuna"),
            new Translation(LanguageCode.DE, "Wallis und Futuna"),
            new Translation(LanguageCode.EL, "Ουαλίς και Φουτουνά"),
            new Translation(LanguageCode.EN, "Wallis and Futuna"),
            new Translation(LanguageCode.ES, "Wallis y Futuna"),
            new Translation(LanguageCode.ET, "Wallis ja Futuna"),
            new Translation(LanguageCode.FA, "والیس و فوتونا"),
            new Translation(LanguageCode.FI, "Wallis ja Futunasaaret"),
            new Translation(LanguageCode.FR, "Wallis et Futuna"),
            new Translation(LanguageCode.HE, "איי ווליס ופוטונה"),
            new Translation(LanguageCode.HR, "Wallis i Futuna"),
            new Translation(LanguageCode.HU, "Wallis és Futuna"),
            new Translation(LanguageCode.HY, "Ուոլիս և Ֆուտունա"),
            new Translation(LanguageCode.ID, "Wallis and Futuna"),
            new Translation(LanguageCode.IT, "Wallis e Futuna"),
            new Translation(LanguageCode.JA, "ウォリス・フツナ"),
            new Translation(LanguageCode.KA, "უოლისი და ფუტუნა"),
            new Translation(LanguageCode.KK, "Уоллис және Футуна"),
            new Translation(LanguageCode.KO, "월리스 푸 투나"),
            new Translation(LanguageCode.KY, "Уоллис жана Футуна"),
            new Translation(LanguageCode.LT, "Volisas ir Futūna"),
            new Translation(LanguageCode.LV, "Volisa un Futunas salas"),
            new Translation(LanguageCode.MK, "Валис и Футуна"),
            new Translation(LanguageCode.MN, "Уоллис ба Футуна"),
            new Translation(LanguageCode.NB, "Wallis- og Futunaøyene"),
            new Translation(LanguageCode.NL, "Wallis en Futuna"),
            new Translation(LanguageCode.NN, "Wallis- og Futunaøyane"),
            new Translation(LanguageCode.PL, "Wallis i Futuna"),
            new Translation(LanguageCode.PT, "Wallis e Futuna"),
            new Translation(LanguageCode.RO, "Wallis și Futuna"),
            new Translation(LanguageCode.RU, "Уоллис и Футуна"),
            new Translation(LanguageCode.SK, "Wallis a Futuna"),
            new Translation(LanguageCode.SL, "Wallis in Futuna"),
            new Translation(LanguageCode.SR, "Валис и Футуна"),
            new Translation(LanguageCode.SV, "Wallis- och Futunaöarna"),
            new Translation(LanguageCode.TR, "Wallis ve Futuna Adaları"),
            new Translation(LanguageCode.UK, "Волліс і Футуна"),
            new Translation(LanguageCode.UZ, "Uollis va Futuna"),
            new Translation(LanguageCode.ZH, "瓦利斯和富图纳"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.WF;
        public Alpha3Code Alpha3Code => Alpha3Code.WLF;
        public int NumericCode => 876;
        public string[] TLD => new [] { ".wf" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XpfCurrency() };
        public string[] CallingCodes => new [] { "681" };
    }
}
