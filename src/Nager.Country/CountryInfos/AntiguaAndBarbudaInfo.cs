namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public class AntiguaAndBarbudaInfo : ICountryInfo
    {
        public string CommonName => "Antigua and Barbuda";
        public string OfficialName => "Antigua and Barbuda";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أنتيغوا وباربودا"),
            new Translation(LanguageCode.AZ, "Antiqua və Barbuda"),
            new Translation(LanguageCode.BE, "Антыгуа і Барбуда"),
            new Translation(LanguageCode.BG, "Антигуа и Барбуда"),
            new Translation(LanguageCode.BS, "Antigva i Barbuda"),
            new Translation(LanguageCode.CA, "Antigua i Barbuda"),
            new Translation(LanguageCode.CS, "Antigua a Barbuda"),
            new Translation(LanguageCode.DA, "Antigua og Barbuda"),
            new Translation(LanguageCode.DE, "Antigua und Barbuda"),
            new Translation(LanguageCode.EL, "Αντίγκουα και Μπαρμπούντα"),
            new Translation(LanguageCode.EN, "Antigua and Barbuda"),
            new Translation(LanguageCode.ES, "Antigua y Barbuda"),
            new Translation(LanguageCode.ET, "Antigua ja Barbuda"),
            new Translation(LanguageCode.FA, "آنتیگوا و باربودا"),
            new Translation(LanguageCode.FI, "Antigua ja Barbuda"),
            new Translation(LanguageCode.FR, "Antigua et Barbuda"),
            new Translation(LanguageCode.HE, "אנטיגואה וברבודה"),
            new Translation(LanguageCode.HR, "Antigva i Barbuda"),
            new Translation(LanguageCode.HU, "Antigua és Barbuda"),
            new Translation(LanguageCode.HY, "Անտիգուա և Բարբուդա"),
            new Translation(LanguageCode.ID, "Antigua dan Barbuda"),
            new Translation(LanguageCode.IT, "Antigua e Barbuda"),
            new Translation(LanguageCode.JA, "アンティグア・バーブーダ"),
            new Translation(LanguageCode.KA, "ანტიგუა და ბარბუდა"),
            new Translation(LanguageCode.KK, "Антигуа және Барбуда"),
            new Translation(LanguageCode.KO, "앤티가 바부 다"),
            new Translation(LanguageCode.KY, "Антигуа жана Барбуда"),
            new Translation(LanguageCode.LT, "Antigva ir Barbuda"),
            new Translation(LanguageCode.LV, "Antigva un Barbuda"),
            new Translation(LanguageCode.MK, "Антигва и Барбуда"),
            new Translation(LanguageCode.MN, "Антигуа ба Барбуда"),
            new Translation(LanguageCode.NB, "Antigua og Barbuda"),
            new Translation(LanguageCode.NL, "Antigua en Barbuda"),
            new Translation(LanguageCode.NN, "Antigua og Barbuda"),
            new Translation(LanguageCode.PL, "Antigua i Barbuda"),
            new Translation(LanguageCode.PT, "Antígua e Barbuda"),
            new Translation(LanguageCode.RO, "Antigua și Barbuda"),
            new Translation(LanguageCode.RU, "Антигуа и Барбуда"),
            new Translation(LanguageCode.SK, "Antigua a Barbuda"),
            new Translation(LanguageCode.SL, "Antigva in Barbuda"),
            new Translation(LanguageCode.SR, "Антигва и Барбуда"),
            new Translation(LanguageCode.SV, "Antigua och Barbuda"),
            new Translation(LanguageCode.TR, "Antigua ve Barbuda"),
            new Translation(LanguageCode.UK, "Антигуа і Барбуда"),
            new Translation(LanguageCode.UZ, "Antigua va Barbuda"),
            new Translation(LanguageCode.ZH, "安地卡及巴布达"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AG;
        public Alpha3Code Alpha3Code => Alpha3Code.ATG;
        public int NumericCode => 028;
        public string[] TLD => new [] { ".ag" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "XCD" };
        public string[] CallingCodes => new [] { "1268" };
    }
}
