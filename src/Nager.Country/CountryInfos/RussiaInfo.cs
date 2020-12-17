namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Russia
    /// </summary>
    public class RussiaInfo : ICountryInfo
    {
        public string CommonName => "Russia";
        public string OfficialName => "Russian Federation";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "روسيا"),
            new Translation(LanguageCode.AZ, "Rusiya"),
            new Translation(LanguageCode.BE, "Расія"),
            new Translation(LanguageCode.BG, "Русия"),
            new Translation(LanguageCode.BS, "Rusija"),
            new Translation(LanguageCode.CA, "Rússia"),
            new Translation(LanguageCode.CS, "Rusko"),
            new Translation(LanguageCode.DA, "Rusland"),
            new Translation(LanguageCode.DE, "Russische Föderation"),
            new Translation(LanguageCode.EL, "Ρωσική Ομοσπονδία"),
            new Translation(LanguageCode.EN, "Russian Federation"),
            new Translation(LanguageCode.ES, "Rusia"),
            new Translation(LanguageCode.ET, "Venemaa"),
            new Translation(LanguageCode.FA, "روسیه"),
            new Translation(LanguageCode.FI, "Venäjä"),
            new Translation(LanguageCode.FR, "Russie"),
            new Translation(LanguageCode.HE, "רוסיה"),
            new Translation(LanguageCode.HR, "Rusija"),
            new Translation(LanguageCode.HU, "Oroszország"),
            new Translation(LanguageCode.HY, "Ռուսաստան"),
            new Translation(LanguageCode.ID, "Rusia"),
            new Translation(LanguageCode.IT, "Russia"),
            new Translation(LanguageCode.JA, "ロシア連邦"),
            new Translation(LanguageCode.KA, "რუსეთი"),
            new Translation(LanguageCode.KK, "Ресей"),
            new Translation(LanguageCode.KO, "러시아 연방"),
            new Translation(LanguageCode.KY, "Россия"),
            new Translation(LanguageCode.LT, "Rusija"),
            new Translation(LanguageCode.LV, "Krievija"),
            new Translation(LanguageCode.MK, "Русија"),
            new Translation(LanguageCode.MN, "Орос"),
            new Translation(LanguageCode.NB, "Russland"),
            new Translation(LanguageCode.NL, "Rusland"),
            new Translation(LanguageCode.NN, "Russland"),
            new Translation(LanguageCode.PL, "Rosja"),
            new Translation(LanguageCode.PT, "Rússia"),
            new Translation(LanguageCode.RO, "Rusia"),
            new Translation(LanguageCode.RU, "Россия"),
            new Translation(LanguageCode.SK, "Rusko"),
            new Translation(LanguageCode.SL, "Rusija"),
            new Translation(LanguageCode.SR, "Русија"),
            new Translation(LanguageCode.SV, "Ryssland"),
            new Translation(LanguageCode.TR, "Rusya"),
            new Translation(LanguageCode.UK, "Росія"),
            new Translation(LanguageCode.UZ, "Rossiya"),
            new Translation(LanguageCode.ZH, "俄罗斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.RU;
        public Alpha3Code Alpha3Code => Alpha3Code.RUS;
        public int NumericCode => 643;
        public string[] TLD => new [] { ".ru", ".su", ".рф" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AZ,
            Alpha2Code.BY,
            Alpha2Code.CN,
            Alpha2Code.EE,
            Alpha2Code.FI,
            Alpha2Code.GE,
            Alpha2Code.KZ,
            Alpha2Code.KP,
            Alpha2Code.LV,
            Alpha2Code.LT,
            Alpha2Code.MN,
            Alpha2Code.NO,
            Alpha2Code.PL,
            Alpha2Code.UA,
        };

        public string[] Currencies => new [] { "RUB" };
        public string[] CallingCodes => new [] { "7" };
    }
}
