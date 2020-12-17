namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    public class SaintBarthelemyInfo : ICountryInfo
    {
        public string CommonName => "Saint Barthélemy";
        public string OfficialName => "Collectivity of Saint BarthélemySaint Barthélemy";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سان بارتيلمي"),
            new Translation(LanguageCode.AZ, "Sent-Bartelemi"),
            new Translation(LanguageCode.BE, "Сен-Бартэльмі"),
            new Translation(LanguageCode.BG, "Сен Бартелеми"),
            new Translation(LanguageCode.BS, "Sveti Bartolomej"),
            new Translation(LanguageCode.CA, "Saint-Barthélemy"),
            new Translation(LanguageCode.CS, "Svatý Bartoloměj"),
            new Translation(LanguageCode.DA, "Saint-Barthélemy"),
            new Translation(LanguageCode.DE, "Saint-Barthélemy"),
            new Translation(LanguageCode.EL, "Άγιος Βαρθολομαίος"),
            new Translation(LanguageCode.EN, "Saint Barthélemy"),
            new Translation(LanguageCode.ES, "Saint Barthélemy"),
            new Translation(LanguageCode.ET, "Saint Barthélemy"),
            new Translation(LanguageCode.FA, "سن بارتلمی"),
            new Translation(LanguageCode.FI, "Saint-Barthélemy"),
            new Translation(LanguageCode.FR, "Saint-Barthélemy"),
            new Translation(LanguageCode.HE, "סנט ברתולומיאו"),
            new Translation(LanguageCode.HR, "Saint Barthélemy"),
            new Translation(LanguageCode.HU, "Saint Barthélemy"),
            new Translation(LanguageCode.HY, "Սեն Բարտելմի"),
            new Translation(LanguageCode.ID, "Saint Barthélemy"),
            new Translation(LanguageCode.IT, "Saint-Barthélemy"),
            new Translation(LanguageCode.JA, "サン・バルテルミー"),
            new Translation(LanguageCode.KA, "სენ-ბართელმი"),
            new Translation(LanguageCode.KK, "Сен-Бартелеми"),
            new Translation(LanguageCode.KO, "생 바르 텔레 미"),
            new Translation(LanguageCode.KY, "Сент Бартелеми"),
            new Translation(LanguageCode.LT, "Sen Bartelemi"),
            new Translation(LanguageCode.LV, "Senbartelmī"),
            new Translation(LanguageCode.MK, "Свети Вартоломеј"),
            new Translation(LanguageCode.MN, "Сент Бартельми"),
            new Translation(LanguageCode.NB, "Saint-Barthélemy"),
            new Translation(LanguageCode.NL, "Saint Barthélemy"),
            new Translation(LanguageCode.NN, "Saint-Barthélemy"),
            new Translation(LanguageCode.PL, "Saint-Barthélemy"),
            new Translation(LanguageCode.PT, "São Bartolomeu"),
            new Translation(LanguageCode.RO, "Sfântul Bartolomeu"),
            new Translation(LanguageCode.RU, "Сен-Бартелеми"),
            new Translation(LanguageCode.SK, "Svätý Bartolomej"),
            new Translation(LanguageCode.SL, "Saint Barthélemy"),
            new Translation(LanguageCode.SR, "Сен Бартелеми"),
            new Translation(LanguageCode.SV, "Saint-Barthélemy"),
            new Translation(LanguageCode.TR, "Saint Barthelemy"),
            new Translation(LanguageCode.UK, "Сен-Бартельмі"),
            new Translation(LanguageCode.UZ, "Sen-Bartelemi"),
            new Translation(LanguageCode.ZH, "圣巴泰勒米"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BL;
        public Alpha3Code Alpha3Code => Alpha3Code.BLM;
        public int NumericCode => 652;
        public string[] TLD => new [] { ".bl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "590" };
    }
}
