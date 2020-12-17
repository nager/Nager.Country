namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Moldova
    /// </summary>
    public class MoldovaInfo : ICountryInfo
    {
        public string CommonName => "Moldova";
        public string OfficialName => "Republic of Moldova";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مولدوفا"),
            new Translation(LanguageCode.AZ, "Moldova"),
            new Translation(LanguageCode.BE, "Малдова"),
            new Translation(LanguageCode.BG, "Молдова"),
            new Translation(LanguageCode.BS, "Moldavija"),
            new Translation(LanguageCode.CA, "Moldàvia"),
            new Translation(LanguageCode.CS, "Moldavsko"),
            new Translation(LanguageCode.DA, "Moldova"),
            new Translation(LanguageCode.DE, "Moldawien"),
            new Translation(LanguageCode.EL, "Δημοκρατία της Μολδαβίας"),
            new Translation(LanguageCode.EN, "Moldova, Republic of"),
            new Translation(LanguageCode.ES, "Moldavia"),
            new Translation(LanguageCode.ET, "Moldova"),
            new Translation(LanguageCode.FA, "مولداوی"),
            new Translation(LanguageCode.FI, "Moldova"),
            new Translation(LanguageCode.FR, "Moldavie"),
            new Translation(LanguageCode.HE, "מולדובה"),
            new Translation(LanguageCode.HR, "Moldavija"),
            new Translation(LanguageCode.HU, "Moldova"),
            new Translation(LanguageCode.HY, "Մոլդովա"),
            new Translation(LanguageCode.ID, "Moldova"),
            new Translation(LanguageCode.IT, "Moldavia"),
            new Translation(LanguageCode.JA, "モルドバ共和国"),
            new Translation(LanguageCode.KA, "მოლდოვა"),
            new Translation(LanguageCode.KK, "Молдова"),
            new Translation(LanguageCode.KO, "몰도바, 공화국"),
            new Translation(LanguageCode.KY, "Молдова"),
            new Translation(LanguageCode.LT, "Moldova"),
            new Translation(LanguageCode.LV, "Moldova"),
            new Translation(LanguageCode.MK, "Молдавија"),
            new Translation(LanguageCode.MN, "Молдав"),
            new Translation(LanguageCode.NB, "Moldova"),
            new Translation(LanguageCode.NL, "Moldavië"),
            new Translation(LanguageCode.NN, "Moldova"),
            new Translation(LanguageCode.PL, "Mołdawia"),
            new Translation(LanguageCode.PT, "Moldávia"),
            new Translation(LanguageCode.RO, "Republica Moldova"),
            new Translation(LanguageCode.RU, "Молдавия"),
            new Translation(LanguageCode.SK, "Moldavsko"),
            new Translation(LanguageCode.SL, "Moldavija"),
            new Translation(LanguageCode.SR, "Молдавија"),
            new Translation(LanguageCode.SV, "Moldavien"),
            new Translation(LanguageCode.TR, "Moldova"),
            new Translation(LanguageCode.UK, "Молдова"),
            new Translation(LanguageCode.UZ, "Moldova"),
            new Translation(LanguageCode.ZH, "摩尔多瓦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MD;
        public Alpha3Code Alpha3Code => Alpha3Code.MDA;
        public int NumericCode => 498;
        public string[] TLD => new [] { ".md" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.RO,
            Alpha2Code.UA,
        };

        public string[] Currencies => new [] { "MDL" };
        public string[] CallingCodes => new [] { "373" };
    }
}
