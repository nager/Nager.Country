using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Albania
    /// </summary>
    public class AlbaniaInfo : ICountryInfo
    {
        public string CommonName => "Albania";
        public string OfficialName => "Republic of Albania";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ألبانيا"),
            new Translation(LanguageCode.AZ, "Albaniya"),
            new Translation(LanguageCode.BE, "Албанія"),
            new Translation(LanguageCode.BG, "Албания"),
            new Translation(LanguageCode.BS, "Albanija"),
            new Translation(LanguageCode.CA, "Albània"),
            new Translation(LanguageCode.CS, "Albánie"),
            new Translation(LanguageCode.DA, "Albanien"),
            new Translation(LanguageCode.DE, "Albanien"),
            new Translation(LanguageCode.EL, "Αλβανία"),
            new Translation(LanguageCode.EN, "Albania"),
            new Translation(LanguageCode.ES, "Albania"),
            new Translation(LanguageCode.ET, "Albaania"),
            new Translation(LanguageCode.FA, "آلبانی"),
            new Translation(LanguageCode.FI, "Albania"),
            new Translation(LanguageCode.FR, "Albanie"),
            new Translation(LanguageCode.HE, "אלבניה"),
            new Translation(LanguageCode.HR, "Albanija"),
            new Translation(LanguageCode.HU, "Albánia"),
            new Translation(LanguageCode.HY, "Ալբանիա"),
            new Translation(LanguageCode.ID, "Albania"),
            new Translation(LanguageCode.IT, "Albania"),
            new Translation(LanguageCode.JA, "アルバニア"),
            new Translation(LanguageCode.KA, "ალბანეთი"),
            new Translation(LanguageCode.KK, "Албания"),
            new Translation(LanguageCode.KO, "알바니아"),
            new Translation(LanguageCode.KY, "Албания"),
            new Translation(LanguageCode.LT, "Albanija"),
            new Translation(LanguageCode.LV, "Albānija"),
            new Translation(LanguageCode.MK, "Албанија"),
            new Translation(LanguageCode.MN, "Албани"),
            new Translation(LanguageCode.NB, "Albania"),
            new Translation(LanguageCode.NL, "Albanië"),
            new Translation(LanguageCode.NN, "Albania"),
            new Translation(LanguageCode.PL, "Albania"),
            new Translation(LanguageCode.PT, "Albânia"),
            new Translation(LanguageCode.RO, "Albania"),
            new Translation(LanguageCode.RU, "Албания"),
            new Translation(LanguageCode.SK, "Albánsko"),
            new Translation(LanguageCode.SL, "Albanija"),
            new Translation(LanguageCode.SR, "Албанија"),
            new Translation(LanguageCode.SV, "Albanien"),
            new Translation(LanguageCode.TR, "Arnavutluk"),
            new Translation(LanguageCode.UK, "Албанія"),
            new Translation(LanguageCode.UZ, "Albaniya"),
            new Translation(LanguageCode.ZH, "阿尔巴尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AL;
        public Alpha3Code Alpha3Code => Alpha3Code.ALB;
        public int NumericCode => 008;
        public string[] TLD => new [] { ".al" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ME,
            Alpha2Code.GR,
            Alpha2Code.MK,
        };

        public ICurrency[] Currencies => new [] { new AllCurrency() };
        public string[] CallingCodes => new [] { "355" };
    }
}
