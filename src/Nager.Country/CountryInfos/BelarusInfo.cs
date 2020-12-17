namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belarus
    /// </summary>
    public class BelarusInfo : ICountryInfo
    {
        public string CommonName => "Belarus";
        public string OfficialName => "Republic of Belarus";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "روسيا البيضاء"),
            new Translation(LanguageCode.AZ, "Belarus"),
            new Translation(LanguageCode.BE, "Беларусь"),
            new Translation(LanguageCode.BG, "Беларус"),
            new Translation(LanguageCode.BS, "Bjelorusija"),
            new Translation(LanguageCode.CA, "Bielorússia"),
            new Translation(LanguageCode.CS, "Bělorusko"),
            new Translation(LanguageCode.DA, "Hviderusland"),
            new Translation(LanguageCode.DE, "Weißrussland"),
            new Translation(LanguageCode.EL, "Λευκορωσία"),
            new Translation(LanguageCode.EN, "Belarus"),
            new Translation(LanguageCode.ES, "Belarús"),
            new Translation(LanguageCode.ET, "Valgevene"),
            new Translation(LanguageCode.FA, "بلاروس"),
            new Translation(LanguageCode.FI, "Valko-Venäjä"),
            new Translation(LanguageCode.FR, "Bielorussie"),
            new Translation(LanguageCode.HE, "בלארוס"),
            new Translation(LanguageCode.HR, "Bjelorusija"),
            new Translation(LanguageCode.HU, "Fehéroroszország"),
            new Translation(LanguageCode.HY, "Բելառուս"),
            new Translation(LanguageCode.ID, "Belarusia"),
            new Translation(LanguageCode.IT, "Bielorussia"),
            new Translation(LanguageCode.JA, "ベラルーシ"),
            new Translation(LanguageCode.KA, "ბელარუსი"),
            new Translation(LanguageCode.KK, "Беларусь"),
            new Translation(LanguageCode.KO, "벨라루스"),
            new Translation(LanguageCode.KY, "Беларусь"),
            new Translation(LanguageCode.LT, "Baltarusija"),
            new Translation(LanguageCode.LV, "Baltkrievija"),
            new Translation(LanguageCode.MK, "Белорусија"),
            new Translation(LanguageCode.MN, "Беларусь"),
            new Translation(LanguageCode.NB, "Hviterussland"),
            new Translation(LanguageCode.NL, "Wit-Rusland"),
            new Translation(LanguageCode.NN, "Kviterussland"),
            new Translation(LanguageCode.PL, "Białoruś"),
            new Translation(LanguageCode.PT, "Bielorrússia"),
            new Translation(LanguageCode.RO, "Belarus"),
            new Translation(LanguageCode.RU, "Беларусь"),
            new Translation(LanguageCode.SK, "Bielorusko"),
            new Translation(LanguageCode.SL, "Belorusija"),
            new Translation(LanguageCode.SR, "Белорусија"),
            new Translation(LanguageCode.SV, "Vitryssland"),
            new Translation(LanguageCode.TR, "Beyaz Rusya"),
            new Translation(LanguageCode.UK, "Білорусь"),
            new Translation(LanguageCode.UZ, "Belarus"),
            new Translation(LanguageCode.ZH, "白俄罗斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BY;
        public Alpha3Code Alpha3Code => Alpha3Code.BLR;
        public int NumericCode => 112;
        public string[] TLD => new [] { ".by" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.LT,
            Alpha2Code.PL,
            Alpha2Code.RU,
            Alpha2Code.UA,
        };

        public string[] Currencies => new [] { "BYN" };
        public string[] CallingCodes => new [] { "375" };
    }
}
