namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Finland
    /// </summary>
    public class FinlandInfo : ICountryInfo
    {
        public string CommonName => "Finland";
        public string OfficialName => "Republic of Finland";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "فنلندا"),
            new Translation(LanguageCode.AZ, "Finlandiya"),
            new Translation(LanguageCode.BE, "Фінляндыя"),
            new Translation(LanguageCode.BG, "Финландия"),
            new Translation(LanguageCode.BS, "Finska"),
            new Translation(LanguageCode.CA, "Finlàndia"),
            new Translation(LanguageCode.CS, "Finsko"),
            new Translation(LanguageCode.DA, "Finland"),
            new Translation(LanguageCode.DE, "Finnland"),
            new Translation(LanguageCode.EL, "Φινλανδία"),
            new Translation(LanguageCode.EN, "Finland"),
            new Translation(LanguageCode.ES, "Finlandia"),
            new Translation(LanguageCode.ET, "Soome"),
            new Translation(LanguageCode.FA, "فنلاند"),
            new Translation(LanguageCode.FI, "Suomi"),
            new Translation(LanguageCode.FR, "Finlande"),
            new Translation(LanguageCode.HE, "פינלנד"),
            new Translation(LanguageCode.HR, "Finska"),
            new Translation(LanguageCode.HU, "Finnország"),
            new Translation(LanguageCode.HY, "Ֆինլանդիա"),
            new Translation(LanguageCode.ID, "Finlandia"),
            new Translation(LanguageCode.IT, "Finlandia"),
            new Translation(LanguageCode.JA, "フィンランド"),
            new Translation(LanguageCode.KA, "ფინეთი"),
            new Translation(LanguageCode.KK, "Финляндия"),
            new Translation(LanguageCode.KO, "핀란드"),
            new Translation(LanguageCode.KY, "Финляндия"),
            new Translation(LanguageCode.LT, "Suomija"),
            new Translation(LanguageCode.LV, "Somija"),
            new Translation(LanguageCode.MK, "Финска"),
            new Translation(LanguageCode.MN, "Финланд"),
            new Translation(LanguageCode.NB, "Finland"),
            new Translation(LanguageCode.NL, "Finland"),
            new Translation(LanguageCode.NN, "Finland"),
            new Translation(LanguageCode.PL, "Finlandia"),
            new Translation(LanguageCode.PT, "Finlândia"),
            new Translation(LanguageCode.RO, "Finlanda"),
            new Translation(LanguageCode.RU, "Финляндия"),
            new Translation(LanguageCode.SK, "Fínsko"),
            new Translation(LanguageCode.SL, "Finska"),
            new Translation(LanguageCode.SR, "Финска"),
            new Translation(LanguageCode.SV, "Finland"),
            new Translation(LanguageCode.TR, "Finlandiya"),
            new Translation(LanguageCode.UK, "Фінляндія"),
            new Translation(LanguageCode.UZ, "Finlandiya"),
            new Translation(LanguageCode.ZH, "芬兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.FI;
        public Alpha3Code Alpha3Code => Alpha3Code.FIN;
        public int NumericCode => 246;
        public string[] TLD => new [] { ".fi" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.NO,
            Alpha2Code.SE,
            Alpha2Code.RU,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "358" };
    }
}
