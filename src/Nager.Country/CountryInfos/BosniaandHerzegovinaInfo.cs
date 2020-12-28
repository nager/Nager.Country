using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    public class BosniaandHerzegovinaInfo : ICountryInfo
    {
        public string CommonName => "Bosnia and Herzegovina";
        public string OfficialName => "Bosnia and Herzegovina";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "البوسنة والهرسك"),
            new Translation(LanguageCode.AZ, "Bosniya və Herseqovina"),
            new Translation(LanguageCode.BE, "Боснія і Герцагавіна"),
            new Translation(LanguageCode.BG, "Босна и Херцеговина"),
            new Translation(LanguageCode.BS, "Bosna i Hercegovina"),
            new Translation(LanguageCode.CA, "Bòsnia i Hercegovina"),
            new Translation(LanguageCode.CS, "Bosna a Hercegovina"),
            new Translation(LanguageCode.DA, "Bosnien-Hercegovina"),
            new Translation(LanguageCode.DE, "Bosnien und Herzegowina"),
            new Translation(LanguageCode.EL, "Βοσνία και Ερζεγοβίνη"),
            new Translation(LanguageCode.EN, "Bosnia and Herzegovina"),
            new Translation(LanguageCode.ES, "Bosnia y Herzegovina"),
            new Translation(LanguageCode.ET, "Bosnia ja Hertsegoviina"),
            new Translation(LanguageCode.FA, "بوسنی و هرزگوین"),
            new Translation(LanguageCode.FI, "Bosnia ja Hertsegovina"),
            new Translation(LanguageCode.FR, "Bosnie-Herzégovine"),
            new Translation(LanguageCode.HE, "בוסניה והרצגובינה"),
            new Translation(LanguageCode.HR, "Bosna i Hercegovina"),
            new Translation(LanguageCode.HU, "Bosznia-Hercegovina"),
            new Translation(LanguageCode.HY, "Բոսնիա և Հերցեգովինա"),
            new Translation(LanguageCode.ID, "Bosnia dan Herzegovina"),
            new Translation(LanguageCode.IT, "Bosnia ed Erzegovina"),
            new Translation(LanguageCode.JA, "ボスニア・ヘルツェゴビナ"),
            new Translation(LanguageCode.KA, "ბოსნია და ჰერცეგოვინა"),
            new Translation(LanguageCode.KK, "Босния және Герцеговина"),
            new Translation(LanguageCode.KO, "보스니아 헤르체고비나"),
            new Translation(LanguageCode.KY, "Босния жана Герцеговина"),
            new Translation(LanguageCode.LT, "Bosnija ir Hercegovina"),
            new Translation(LanguageCode.LV, "Bosnija un Hercegovina"),
            new Translation(LanguageCode.MK, "Босна и Херцеговина"),
            new Translation(LanguageCode.MN, "Босни Герцеговин"),
            new Translation(LanguageCode.NB, "Bosnia-Hercegovina"),
            new Translation(LanguageCode.NL, "Bosnië-Herzegovina"),
            new Translation(LanguageCode.NN, "Bosnia-Hercegovina"),
            new Translation(LanguageCode.PL, "Bośnia i Hercegowina"),
            new Translation(LanguageCode.PT, "Bósnia e Herzegovina"),
            new Translation(LanguageCode.RO, "Bosnia și Herțegovina"),
            new Translation(LanguageCode.RU, "Босния и Герцеговина"),
            new Translation(LanguageCode.SK, "Bosna a Hercegovina"),
            new Translation(LanguageCode.SL, "Bosna in Hercegovina"),
            new Translation(LanguageCode.SR, "Босна и Херцеговина"),
            new Translation(LanguageCode.SV, "Bosnien och Hercegovina"),
            new Translation(LanguageCode.TR, "Bosna Hersek"),
            new Translation(LanguageCode.UK, "Боснія і Герцеговина"),
            new Translation(LanguageCode.UZ, "Bosniya va Gertsegovina"),
            new Translation(LanguageCode.ZH, "波斯尼亚和黑塞哥维那"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BA;
        public Alpha3Code Alpha3Code => Alpha3Code.BIH;
        public int NumericCode => 070;
        public string[] TLD => new [] { ".ba" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.HR,
            Alpha2Code.ME,
            Alpha2Code.RS,
        };

        public ICurrency[] Currencies => new [] { new BamCurrency() };
        public string[] CallingCodes => new [] { "387" };
    }
}
