namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    public class TurksAndCaicosIslandsInfo : ICountryInfo
    {
        public string CommonName => "Turks and Caicos Islands";
        public string OfficialName => "Turks and Caicos Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر توركس وكايكوس"),
            new Translation(LanguageCode.AZ, "Törks və Kaykos adaları"),
            new Translation(LanguageCode.BE, "Цёркс і Кайкас"),
            new Translation(LanguageCode.BG, "острови Търкс и Кайкос"),
            new Translation(LanguageCode.BS, "Ostrva Turks i Kaikos"),
            new Translation(LanguageCode.CA, "Turks i Caicos, illes"),
            new Translation(LanguageCode.CS, "Turks a Caicos"),
            new Translation(LanguageCode.DA, "Turks- og Caicosøerne"),
            new Translation(LanguageCode.DE, "Turks- und Caicosinseln"),
            new Translation(LanguageCode.EL, "Τερκς και Κέικος"),
            new Translation(LanguageCode.EN, "Turks and Caicos Islands"),
            new Translation(LanguageCode.ES, "Islas Turcas y Caicos"),
            new Translation(LanguageCode.ET, "Turks ja Caicos"),
            new Translation(LanguageCode.FA, "جزایر تورکس و کایکوس"),
            new Translation(LanguageCode.FI, "Turks- ja Caicossaaret"),
            new Translation(LanguageCode.FR, "Îles Turques-et-Caïques"),
            new Translation(LanguageCode.HE, "איי טורקס וקאיקוס"),
            new Translation(LanguageCode.HR, "Otoci Turks i Caicos"),
            new Translation(LanguageCode.HU, "Turks- és Caicos-szigetek"),
            new Translation(LanguageCode.HY, "Թըրքս և Կայկոս կղզիներ"),
            new Translation(LanguageCode.ID, "Turks dan Caicos Islands"),
            new Translation(LanguageCode.IT, "Isole Turks e Caicos"),
            new Translation(LanguageCode.JA, "タークス・カイコス諸島"),
            new Translation(LanguageCode.KA, "თერქს-ქაიქოსის კუნძულები"),
            new Translation(LanguageCode.KK, "Теркс және Кайкос аралдары"),
            new Translation(LanguageCode.KO, "터크 스 케이 커스 제도"),
            new Translation(LanguageCode.KY, "Түркс жана Кайкос аралдары"),
            new Translation(LanguageCode.LT, "Terkso ir Kaikoso Salos"),
            new Translation(LanguageCode.LV, "Tērksas un Kaikosas salas"),
            new Translation(LanguageCode.MK, "Острови Туркс и Каикос"),
            new Translation(LanguageCode.MN, "Турк ба Кайкосын Арлууд"),
            new Translation(LanguageCode.NB, "Turks- og Caicosøyene"),
            new Translation(LanguageCode.NL, "Turks- en Caicoseilanden"),
            new Translation(LanguageCode.NN, "Turks- og Caicosøyane"),
            new Translation(LanguageCode.PL, "Turks i Caicos"),
            new Translation(LanguageCode.PT, "Ilhas Turks e Caicos"),
            new Translation(LanguageCode.RO, "Insulele Turks și Caicos"),
            new Translation(LanguageCode.RU, "Теркс и Кайкос"),
            new Translation(LanguageCode.SK, "Turks a Caicos"),
            new Translation(LanguageCode.SL, "Otoki Turks in Caicos"),
            new Translation(LanguageCode.SR, "Острва Туркс и Каикос"),
            new Translation(LanguageCode.SV, "Turks- och Caicosöarna"),
            new Translation(LanguageCode.TR, "Turks ve Caicos Adaları"),
            new Translation(LanguageCode.UK, "Острови Теркс і Кайкос"),
            new Translation(LanguageCode.UZ, "Turks va Kaykos orollari"),
            new Translation(LanguageCode.ZH, "特克斯和凯科斯群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TC;
        public Alpha3Code Alpha3Code => Alpha3Code.TCA;
        public int NumericCode => 796;
        public string[] TLD => new [] { ".tc" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "USD" };
        public string[] CallingCodes => new [] { "1649" };
    }
}
