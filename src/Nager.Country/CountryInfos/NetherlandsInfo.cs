using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Netherlands
    /// </summary>
    public class NetherlandsInfo : ICountryInfo
    {
        public string CommonName => "Netherlands";
        public string OfficialName => "Netherlands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "هولندا"),
            new Translation(LanguageCode.AZ, "Niderland"),
            new Translation(LanguageCode.BE, "Нідэрланды"),
            new Translation(LanguageCode.BG, "Нидерландия"),
            new Translation(LanguageCode.BS, "Holandija"),
            new Translation(LanguageCode.CA, "Països Baixos"),
            new Translation(LanguageCode.CS, "Nizozemsko"),
            new Translation(LanguageCode.DA, "Holland"),
            new Translation(LanguageCode.DE, "Niederlande"),
            new Translation(LanguageCode.EL, "Ολλανδία"),
            new Translation(LanguageCode.EN, "Netherlands"),
            new Translation(LanguageCode.ES, "Países Bajos"),
            new Translation(LanguageCode.ET, "Holland"),
            new Translation(LanguageCode.FA, "هلند"),
            new Translation(LanguageCode.FI, "Alankomaat"),
            new Translation(LanguageCode.FR, "Pays-Bas"),
            new Translation(LanguageCode.HE, "הולנד"),
            new Translation(LanguageCode.HR, "Nizozemska"),
            new Translation(LanguageCode.HU, "Hollandia"),
            new Translation(LanguageCode.HY, "Նիդեռլանդներ"),
            new Translation(LanguageCode.ID, "Belanda"),
            new Translation(LanguageCode.IT, "Paesi Bassi"),
            new Translation(LanguageCode.JA, "オランダ"),
            new Translation(LanguageCode.KA, "ნიდერლანდები"),
            new Translation(LanguageCode.KK, "Нидерланд"),
            new Translation(LanguageCode.KO, "네덜란드"),
            new Translation(LanguageCode.KY, "Нидерланддар"),
            new Translation(LanguageCode.LT, "Nyderlandai"),
            new Translation(LanguageCode.LV, "Nīderlande"),
            new Translation(LanguageCode.MK, "Холандија"),
            new Translation(LanguageCode.MN, "Нидерланд"),
            new Translation(LanguageCode.NB, "Nederland"),
            new Translation(LanguageCode.NL, "Nederland"),
            new Translation(LanguageCode.NN, "Nederland"),
            new Translation(LanguageCode.PL, "Holandia"),
            new Translation(LanguageCode.PT, "Holanda"),
            new Translation(LanguageCode.RO, "Țările de Jos"),
            new Translation(LanguageCode.RU, "Нидерланды"),
            new Translation(LanguageCode.SK, "Holandsko"),
            new Translation(LanguageCode.SL, "Nizozemska"),
            new Translation(LanguageCode.SR, "Холандија"),
            new Translation(LanguageCode.SV, "Nederländerna"),
            new Translation(LanguageCode.TR, "Hollanda"),
            new Translation(LanguageCode.UK, "Нідерланди"),
            new Translation(LanguageCode.UZ, "Niderlandiya"),
            new Translation(LanguageCode.ZH, "荷兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.NL;
        public Alpha3Code Alpha3Code => Alpha3Code.NLD;
        public int NumericCode => 528;
        public string[] TLD => new [] { ".nl" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BE,
            Alpha2Code.DE,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "31" };
    }
}
