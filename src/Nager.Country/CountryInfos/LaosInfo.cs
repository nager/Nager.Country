namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Laos
    /// </summary>
    public class LaosInfo : ICountryInfo
    {
        public string CommonName => "Laos";
        public string OfficialName => "Lao People's Democratic Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "لاوس"),
            new Translation(LanguageCode.AZ, "Laos"),
            new Translation(LanguageCode.BE, "Лаос"),
            new Translation(LanguageCode.BG, "Лаос"),
            new Translation(LanguageCode.BS, "Laos"),
            new Translation(LanguageCode.CA, "Laos"),
            new Translation(LanguageCode.CS, "Laos"),
            new Translation(LanguageCode.DA, "Laos"),
            new Translation(LanguageCode.DE, "Laos"),
            new Translation(LanguageCode.EL, "Λαϊκή Δημοκρατία του Λάος"),
            new Translation(LanguageCode.EN, "Lao People's Democratic Republic"),
            new Translation(LanguageCode.ES, "República Democrática Popular de Lao"),
            new Translation(LanguageCode.ET, "Laos"),
            new Translation(LanguageCode.FA, "لائوس"),
            new Translation(LanguageCode.FI, "Laos"),
            new Translation(LanguageCode.FR, "Laos"),
            new Translation(LanguageCode.HE, "לאוס"),
            new Translation(LanguageCode.HR, "Laos"),
            new Translation(LanguageCode.HU, "Laosz"),
            new Translation(LanguageCode.HY, "Լաոս"),
            new Translation(LanguageCode.ID, "Laos"),
            new Translation(LanguageCode.IT, "Laos"),
            new Translation(LanguageCode.JA, "ラオス人民民主共和国"),
            new Translation(LanguageCode.KA, "ლაოსი"),
            new Translation(LanguageCode.KK, "Лаос"),
            new Translation(LanguageCode.KO, "라오스 인민 민주주의 공화국"),
            new Translation(LanguageCode.KY, "Лаос"),
            new Translation(LanguageCode.LT, "Laosas"),
            new Translation(LanguageCode.LV, "Laosa"),
            new Translation(LanguageCode.MK, "Лаос"),
            new Translation(LanguageCode.MN, "Лаос"),
            new Translation(LanguageCode.NB, "Laos"),
            new Translation(LanguageCode.NL, "Laos"),
            new Translation(LanguageCode.NN, "Laos"),
            new Translation(LanguageCode.PL, "Laos"),
            new Translation(LanguageCode.PT, "Laos"),
            new Translation(LanguageCode.RO, "Laos"),
            new Translation(LanguageCode.RU, "Лаос"),
            new Translation(LanguageCode.SK, "Laos"),
            new Translation(LanguageCode.SL, "Laos"),
            new Translation(LanguageCode.SR, "Лаос"),
            new Translation(LanguageCode.SV, "Laos"),
            new Translation(LanguageCode.TR, "Laos"),
            new Translation(LanguageCode.UK, "Лаос"),
            new Translation(LanguageCode.UZ, "Laos"),
            new Translation(LanguageCode.ZH, "老挝"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LA;
        public Alpha3Code Alpha3Code => Alpha3Code.LAO;
        public int NumericCode => 418;
        public string[] TLD => new [] { ".la" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.MM,
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.TH,
            Alpha2Code.VN,
        };

        public string[] Currencies => new [] { "LAK" };
        public string[] CallingCodes => new [] { "856" };
    }
}
