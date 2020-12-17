namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ecuador
    /// </summary>
    public class EcuadorInfo : ICountryInfo
    {
        public string CommonName => "Ecuador";
        public string OfficialName => "Republic of Ecuador";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الإكوادور"),
            new Translation(LanguageCode.AZ, "Ekvador"),
            new Translation(LanguageCode.BE, "Эквадор"),
            new Translation(LanguageCode.BG, "Еквадор"),
            new Translation(LanguageCode.BS, "Ekvador"),
            new Translation(LanguageCode.CA, "Equador"),
            new Translation(LanguageCode.CS, "Ekvádor"),
            new Translation(LanguageCode.DA, "Ecuador"),
            new Translation(LanguageCode.DE, "Ecuador"),
            new Translation(LanguageCode.EL, "Εκουαδόρ"),
            new Translation(LanguageCode.EN, "Ecuador"),
            new Translation(LanguageCode.ES, "Ecuador"),
            new Translation(LanguageCode.ET, "Ecuador"),
            new Translation(LanguageCode.FA, "اکوادور"),
            new Translation(LanguageCode.FI, "Ecuador"),
            new Translation(LanguageCode.FR, "Équateur"),
            new Translation(LanguageCode.HE, "אקוודור"),
            new Translation(LanguageCode.HR, "Ekvador"),
            new Translation(LanguageCode.HU, "Ecuador"),
            new Translation(LanguageCode.HY, "Էկվադոր"),
            new Translation(LanguageCode.ID, "Ekuador"),
            new Translation(LanguageCode.IT, "Ecuador"),
            new Translation(LanguageCode.JA, "エクアドル"),
            new Translation(LanguageCode.KA, "ეკვადორი"),
            new Translation(LanguageCode.KK, "Эквадор"),
            new Translation(LanguageCode.KO, "에콰도르"),
            new Translation(LanguageCode.KY, "Эквадор"),
            new Translation(LanguageCode.LT, "Ekvadoras"),
            new Translation(LanguageCode.LV, "Ekvadora"),
            new Translation(LanguageCode.MK, "Еквадор"),
            new Translation(LanguageCode.MN, "Эквадор"),
            new Translation(LanguageCode.NB, "Ecuador"),
            new Translation(LanguageCode.NL, "Ecuador"),
            new Translation(LanguageCode.NN, "Ecuador"),
            new Translation(LanguageCode.PL, "Ekwador"),
            new Translation(LanguageCode.PT, "Equador"),
            new Translation(LanguageCode.RO, "Ecuador"),
            new Translation(LanguageCode.RU, "Эквадор"),
            new Translation(LanguageCode.SK, "Ekvádor"),
            new Translation(LanguageCode.SL, "Ekvador"),
            new Translation(LanguageCode.SR, "Еквадор"),
            new Translation(LanguageCode.SV, "Ecuador"),
            new Translation(LanguageCode.TR, "Ekvador"),
            new Translation(LanguageCode.UK, "Еквадор"),
            new Translation(LanguageCode.UZ, "Ekvador"),
            new Translation(LanguageCode.ZH, "厄瓜多尔"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.EC;
        public Alpha3Code Alpha3Code => Alpha3Code.ECU;
        public int NumericCode => 218;
        public string[] TLD => new [] { ".ec" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CO,
            Alpha2Code.PE,
        };

        public string[] Currencies => new [] { "USD" };
        public string[] CallingCodes => new [] { "593" };
    }
}
