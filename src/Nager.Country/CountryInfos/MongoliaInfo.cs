namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mongolia
    /// </summary>
    public class MongoliaInfo : ICountryInfo
    {
        public string CommonName => "Mongolia";
        public string OfficialName => "Mongolia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "منغوليا"),
            new Translation(LanguageCode.AZ, "Monqolustan"),
            new Translation(LanguageCode.BE, "Манголія"),
            new Translation(LanguageCode.BG, "Монголия"),
            new Translation(LanguageCode.BS, "Mongolija"),
            new Translation(LanguageCode.CA, "Mongòlia"),
            new Translation(LanguageCode.CS, "Mongolsko"),
            new Translation(LanguageCode.DA, "Mongoliet"),
            new Translation(LanguageCode.DE, "Mongolei"),
            new Translation(LanguageCode.EL, "Μογγολία"),
            new Translation(LanguageCode.EN, "Mongolia"),
            new Translation(LanguageCode.ES, "Mongolia"),
            new Translation(LanguageCode.ET, "Mongoolia"),
            new Translation(LanguageCode.FA, "مغولستان"),
            new Translation(LanguageCode.FI, "Mongolia"),
            new Translation(LanguageCode.FR, "Mongolie"),
            new Translation(LanguageCode.HE, "מונגוליה"),
            new Translation(LanguageCode.HR, "Mongolija"),
            new Translation(LanguageCode.HU, "Mongólia"),
            new Translation(LanguageCode.HY, "Մոնղոլիա"),
            new Translation(LanguageCode.ID, "Mongolia"),
            new Translation(LanguageCode.IT, "Mongolia"),
            new Translation(LanguageCode.JA, "モンゴル"),
            new Translation(LanguageCode.KA, "მონღოლეთი"),
            new Translation(LanguageCode.KK, "Моңғолия"),
            new Translation(LanguageCode.KO, "몽골리아"),
            new Translation(LanguageCode.KY, "Монголия"),
            new Translation(LanguageCode.LT, "Mongolija"),
            new Translation(LanguageCode.LV, "Mongolija"),
            new Translation(LanguageCode.MK, "Монголија"),
            new Translation(LanguageCode.MN, "Монгол"),
            new Translation(LanguageCode.NB, "Mongolia"),
            new Translation(LanguageCode.NL, "Mongolië"),
            new Translation(LanguageCode.NN, "Mongolia"),
            new Translation(LanguageCode.PL, "Mongolia"),
            new Translation(LanguageCode.PT, "Mongólia"),
            new Translation(LanguageCode.RO, "Mongolia"),
            new Translation(LanguageCode.RU, "Монголия"),
            new Translation(LanguageCode.SK, "Mongolsko"),
            new Translation(LanguageCode.SL, "Mongolija"),
            new Translation(LanguageCode.SR, "Монголија"),
            new Translation(LanguageCode.SV, "Mongoliet"),
            new Translation(LanguageCode.TR, "Moğolistan"),
            new Translation(LanguageCode.UK, "Монголія"),
            new Translation(LanguageCode.UZ, "Mongoliya"),
            new Translation(LanguageCode.ZH, "蒙古"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MN;
        public Alpha3Code Alpha3Code => Alpha3Code.MNG;
        public int NumericCode => 496;
        public string[] TLD => new [] { ".mn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.RU,
        };

        public string[] Currencies => new [] { "MNT" };
        public string[] CallingCodes => new [] { "976" };
    }
}
