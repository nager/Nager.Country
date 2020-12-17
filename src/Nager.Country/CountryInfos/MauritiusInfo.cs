namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mauritius
    /// </summary>
    public class MauritiusInfo : ICountryInfo
    {
        public string CommonName => "Mauritius";
        public string OfficialName => "Republic of Mauritius";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "موريشيوس"),
            new Translation(LanguageCode.AZ, "Mavriki"),
            new Translation(LanguageCode.BE, "Маўрыкій"),
            new Translation(LanguageCode.BG, "Мавриций"),
            new Translation(LanguageCode.BS, "Mauricijus"),
            new Translation(LanguageCode.CA, "Maurici"),
            new Translation(LanguageCode.CS, "Mauricius"),
            new Translation(LanguageCode.DA, "Mauritius"),
            new Translation(LanguageCode.DE, "Mauritius"),
            new Translation(LanguageCode.EL, "Μαυρίκιος"),
            new Translation(LanguageCode.EN, "Mauritius"),
            new Translation(LanguageCode.ES, "Mauricio"),
            new Translation(LanguageCode.ET, "Mauritius"),
            new Translation(LanguageCode.FA, "موریس"),
            new Translation(LanguageCode.FI, "Mauritius"),
            new Translation(LanguageCode.FR, "Maurice"),
            new Translation(LanguageCode.HE, "מאוריציוס"),
            new Translation(LanguageCode.HR, "Mauricijus"),
            new Translation(LanguageCode.HU, "Mauritius"),
            new Translation(LanguageCode.HY, "Մավրիկիոս"),
            new Translation(LanguageCode.ID, "Mauritius"),
            new Translation(LanguageCode.IT, "Mauritius"),
            new Translation(LanguageCode.JA, "モーリシャス"),
            new Translation(LanguageCode.KA, "მავრიკი"),
            new Translation(LanguageCode.KK, "Маврикий"),
            new Translation(LanguageCode.KO, "모리셔스"),
            new Translation(LanguageCode.KY, "Маврикий"),
            new Translation(LanguageCode.LT, "Mauricijus"),
            new Translation(LanguageCode.LV, "Maurīcija"),
            new Translation(LanguageCode.MK, "Маврициус"),
            new Translation(LanguageCode.MN, "Мавритус"),
            new Translation(LanguageCode.NB, "Mauritius"),
            new Translation(LanguageCode.NL, "Mauritius"),
            new Translation(LanguageCode.NN, "Mauritius"),
            new Translation(LanguageCode.PL, "Mauritius"),
            new Translation(LanguageCode.PT, "Maurício"),
            new Translation(LanguageCode.RO, "Mauritius"),
            new Translation(LanguageCode.RU, "Маврикий"),
            new Translation(LanguageCode.SK, "Maurícius"),
            new Translation(LanguageCode.SL, "Mauritius"),
            new Translation(LanguageCode.SR, "Маурицијус"),
            new Translation(LanguageCode.SV, "Mauritius"),
            new Translation(LanguageCode.TR, "Mauritius"),
            new Translation(LanguageCode.UK, "Маврикій"),
            new Translation(LanguageCode.UZ, "Mavrikiy"),
            new Translation(LanguageCode.ZH, "模里西斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MU;
        public Alpha3Code Alpha3Code => Alpha3Code.MUS;
        public int NumericCode => 480;
        public string[] TLD => new [] { ".mu" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "MUR" };
        public string[] CallingCodes => new [] { "230" };
    }
}
