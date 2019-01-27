namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Pakistan
    /// </summary>
    public class PakistanInfo : ICountryInfo
    {
        public string CommonName => "Pakistan";
        public string OfficialName => "Islamic Republic of Pakistan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "باكستان"),
            new Translation(LanguageCode.AZ, "Pakistan"),
            new Translation(LanguageCode.BE, "Пакістан"),
            new Translation(LanguageCode.BG, "Пакистан"),
            new Translation(LanguageCode.BS, "Pakistan"),
            new Translation(LanguageCode.CA, "Pakistan"),
            new Translation(LanguageCode.CS, "Pákistán"),
            new Translation(LanguageCode.DA, "Pakistan"),
            new Translation(LanguageCode.DE, "Pakistan"),
            new Translation(LanguageCode.EL, "Πακιστάν"),
            new Translation(LanguageCode.EN, "Pakistan"),
            new Translation(LanguageCode.ES, "Pakistán"),
            new Translation(LanguageCode.ET, "Pakistan"),
            new Translation(LanguageCode.FA, "پاکستان"),
            new Translation(LanguageCode.FI, "Pakistan"),
            new Translation(LanguageCode.FR, "Pakistan"),
            new Translation(LanguageCode.HE, "פקיסטן"),
            new Translation(LanguageCode.HR, "Pakistan"),
            new Translation(LanguageCode.HU, "Pakisztán"),
            new Translation(LanguageCode.HY, "Պակիստան"),
            new Translation(LanguageCode.ID, "Pakistan"),
            new Translation(LanguageCode.IT, "Pakistan"),
            new Translation(LanguageCode.JA, "パキスタン"),
            new Translation(LanguageCode.KA, "პაკისტანი"),
            new Translation(LanguageCode.KK, "Пәкістан"),
            new Translation(LanguageCode.KO, "파키스탄"),
            new Translation(LanguageCode.KY, "Пакистан"),
            new Translation(LanguageCode.LT, "Pakistanas"),
            new Translation(LanguageCode.LV, "Pakistāna"),
            new Translation(LanguageCode.MK, "Пакистан"),
            new Translation(LanguageCode.MN, "Пакистан"),
            new Translation(LanguageCode.NB, "Pakistan"),
            new Translation(LanguageCode.NL, "Pakistan"),
            new Translation(LanguageCode.NN, "Pakistan"),
            new Translation(LanguageCode.PL, "Pakistan"),
            new Translation(LanguageCode.PT, "Paquistão"),
            new Translation(LanguageCode.RO, "Pakistan"),
            new Translation(LanguageCode.RU, "Пакистан"),
            new Translation(LanguageCode.SK, "Pakistan"),
            new Translation(LanguageCode.SL, "Pakistan"),
            new Translation(LanguageCode.SR, "Пакистан"),
            new Translation(LanguageCode.SV, "Pakistan"),
            new Translation(LanguageCode.TR, "Pakistan"),
            new Translation(LanguageCode.UK, "Пакистан"),
            new Translation(LanguageCode.UZ, "Pokiston"),
            new Translation(LanguageCode.ZH, "巴基斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PK;
        public Alpha3Code Alpha3Code => Alpha3Code.PAK;
        public int NumericCode => 586;
        public string[] TLD => new [] { ".pk" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.IR,
        };

        public string[] Currencies => new [] { "PKR" };
        public string[] CallingCodes => new [] { "92" };
    }
}
