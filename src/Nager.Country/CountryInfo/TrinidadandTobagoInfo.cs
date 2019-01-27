namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    public class TrinidadAndTobagoInfo : ICountryInfo
    {
        public string CommonName => "Trinidad and Tobago";
        public string OfficialName => "Republic of Trinidad and Tobago";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ترينيداد وتوباغو"),
            new Translation(LanguageCode.AZ, "Trinidad və Tobaqo"),
            new Translation(LanguageCode.BE, "Трынідад і Табага"),
            new Translation(LanguageCode.BG, "Тринидад и Тобаго"),
            new Translation(LanguageCode.BS, "Trinidad i Tobago"),
            new Translation(LanguageCode.CA, "Trinitat i Tobago"),
            new Translation(LanguageCode.CS, "Trinidad a Tobago"),
            new Translation(LanguageCode.DA, "Trinidad og Tobago"),
            new Translation(LanguageCode.DE, "Trinidad und Tobago"),
            new Translation(LanguageCode.EL, "Τρινιντάντ και Τομπάγκο"),
            new Translation(LanguageCode.EN, "Trinidad and Tobago"),
            new Translation(LanguageCode.ES, "Trinidad y Tobago"),
            new Translation(LanguageCode.ET, "Trinidad ja Tobago"),
            new Translation(LanguageCode.FA, "ترینیداد و توباگو"),
            new Translation(LanguageCode.FI, "Trinidad ja Tobago"),
            new Translation(LanguageCode.FR, "Trinidad et Tobago"),
            new Translation(LanguageCode.HE, "טרינידד וטובגו"),
            new Translation(LanguageCode.HR, "Trinidad i Tobago"),
            new Translation(LanguageCode.HU, "Trinidad és Tobago"),
            new Translation(LanguageCode.HY, "Տրինիդադ և Տոբագո"),
            new Translation(LanguageCode.ID, "Trinidad dan Tobago"),
            new Translation(LanguageCode.IT, "Trinidad e Tobago"),
            new Translation(LanguageCode.JA, "トリニダード・トバゴ"),
            new Translation(LanguageCode.KA, "ტრინიდადი და ტობაგო"),
            new Translation(LanguageCode.KK, "Тринидад және Тобаго"),
            new Translation(LanguageCode.KO, "트리니다드 토바고"),
            new Translation(LanguageCode.KY, "Тринидад жана Тобаго"),
            new Translation(LanguageCode.LT, "Trinidadas ir Tobagas"),
            new Translation(LanguageCode.LV, "Trinidāda un Tobāgo"),
            new Translation(LanguageCode.MK, "Тринидад и Тобаго"),
            new Translation(LanguageCode.MN, "Тринидад Тобаго"),
            new Translation(LanguageCode.NB, "Trinidad og Tobago"),
            new Translation(LanguageCode.NL, "Trinidad en Tobago"),
            new Translation(LanguageCode.NN, "Trinidad og Tobago"),
            new Translation(LanguageCode.PL, "Trynidad i Tobago"),
            new Translation(LanguageCode.PT, "Trinidad e Tobago"),
            new Translation(LanguageCode.RO, "Trinidad și Tobago"),
            new Translation(LanguageCode.RU, "Тринидад и Тобаго"),
            new Translation(LanguageCode.SK, "Trinidad a Tobago"),
            new Translation(LanguageCode.SL, "Trinidad in Tobago"),
            new Translation(LanguageCode.SR, "Тринидад и Тобаго"),
            new Translation(LanguageCode.SV, "Trinidad och Tobago"),
            new Translation(LanguageCode.TR, "Trinidad ve Tobago"),
            new Translation(LanguageCode.UK, "Тринідад і Тобаго"),
            new Translation(LanguageCode.UZ, "Trinidad va Tobago"),
            new Translation(LanguageCode.ZH, "千里达及托巴哥"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TT;
        public Alpha3Code Alpha3Code => Alpha3Code.TTO;
        public int NumericCode => 780;
        public string[] TLD => new [] { ".tt" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "TTD" };
        public string[] CallingCodes => new [] { "1868" };
    }
}
