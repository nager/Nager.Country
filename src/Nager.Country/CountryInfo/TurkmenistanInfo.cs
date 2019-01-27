namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Turkmenistan
    /// </summary>
    public class TurkmenistanInfo : ICountryInfo
    {
        public string CommonName => "Turkmenistan";
        public string OfficialName => "Turkmenistan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تركمانستان"),
            new Translation(LanguageCode.AZ, "Türkmənistan"),
            new Translation(LanguageCode.BE, "Туркменістан"),
            new Translation(LanguageCode.BG, "Туркменистан"),
            new Translation(LanguageCode.BS, "Turkmenistan"),
            new Translation(LanguageCode.CA, "Turkmenistan"),
            new Translation(LanguageCode.CS, "Turkmenistán"),
            new Translation(LanguageCode.DA, "Turkmenistan"),
            new Translation(LanguageCode.DE, "Turkmenistan"),
            new Translation(LanguageCode.EL, "Τουρκμενιστάν"),
            new Translation(LanguageCode.EN, "Turkmenistan"),
            new Translation(LanguageCode.ES, "Turkmenistán"),
            new Translation(LanguageCode.ET, "Türkmenistan"),
            new Translation(LanguageCode.FA, "ترکمنستان"),
            new Translation(LanguageCode.FI, "Turkmenistan"),
            new Translation(LanguageCode.FR, "Turkménistan"),
            new Translation(LanguageCode.HE, "טורקמניסטן"),
            new Translation(LanguageCode.HR, "Turkmenistan"),
            new Translation(LanguageCode.HU, "Türkmenisztán"),
            new Translation(LanguageCode.HY, "Թուրքմենստան"),
            new Translation(LanguageCode.ID, "Turkmenistan"),
            new Translation(LanguageCode.IT, "Turkmenistan"),
            new Translation(LanguageCode.JA, "トルクメニスタン"),
            new Translation(LanguageCode.KA, "თურქმენეთი"),
            new Translation(LanguageCode.KK, "Түрікменстан"),
            new Translation(LanguageCode.KO, "투르크 메니스탄"),
            new Translation(LanguageCode.KY, "Түркмөнстан"),
            new Translation(LanguageCode.LT, "Turkmėnistanas"),
            new Translation(LanguageCode.LV, "Turkmenistāna"),
            new Translation(LanguageCode.MK, "Туркменистан"),
            new Translation(LanguageCode.MN, "Туркменистан"),
            new Translation(LanguageCode.NB, "Turkmenistan"),
            new Translation(LanguageCode.NL, "Turkmenistan"),
            new Translation(LanguageCode.NN, "Turkmenistan"),
            new Translation(LanguageCode.PL, "Turkmenistan"),
            new Translation(LanguageCode.PT, "Turcomenistão"),
            new Translation(LanguageCode.RO, "Turkmenistan"),
            new Translation(LanguageCode.RU, "Туркмения"),
            new Translation(LanguageCode.SK, "Turkménsko"),
            new Translation(LanguageCode.SL, "Turkmenistan"),
            new Translation(LanguageCode.SR, "Туркменистан"),
            new Translation(LanguageCode.SV, "Turkmenistan"),
            new Translation(LanguageCode.TR, "Türkmenistan"),
            new Translation(LanguageCode.UK, "Туркменістан"),
            new Translation(LanguageCode.UZ, "Turkmaniston"),
            new Translation(LanguageCode.ZH, "土库曼斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TM;
        public Alpha3Code Alpha3Code => Alpha3Code.TKM;
        public int NumericCode => 795;
        public string[] TLD => new [] { ".tm" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.IR,
            Alpha2Code.KZ,
            Alpha2Code.UZ,
        };

        public string[] Currencies => new [] { "TMT" };
        public string[] CallingCodes => new [] { "993" };
    }
}
