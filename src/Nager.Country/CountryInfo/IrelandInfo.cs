namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Ireland
    /// </summary>
    public class IrelandInfo : ICountryInfo
    {
        public string CommonName => "Ireland";
        public string OfficialName => "Republic of Ireland";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أيرلندا"),
            new Translation(LanguageCode.AZ, "İrlandiya"),
            new Translation(LanguageCode.BE, "Ірландыя"),
            new Translation(LanguageCode.BG, "Ирландия"),
            new Translation(LanguageCode.BS, "Irska"),
            new Translation(LanguageCode.CA, "Irlanda"),
            new Translation(LanguageCode.CS, "Irsko"),
            new Translation(LanguageCode.DA, "Irland"),
            new Translation(LanguageCode.DE, "Irland"),
            new Translation(LanguageCode.EL, "Ιρλανδία"),
            new Translation(LanguageCode.EN, "Ireland"),
            new Translation(LanguageCode.ES, "Irlanda"),
            new Translation(LanguageCode.ET, "Iirimaa"),
            new Translation(LanguageCode.FA, "ایرلند"),
            new Translation(LanguageCode.FI, "Irlanti"),
            new Translation(LanguageCode.FR, "Irlande"),
            new Translation(LanguageCode.HE, "אירלנד"),
            new Translation(LanguageCode.HR, "Irska"),
            new Translation(LanguageCode.HU, "Írország"),
            new Translation(LanguageCode.HY, "Իռլանդիա"),
            new Translation(LanguageCode.ID, "Irlandia"),
            new Translation(LanguageCode.IT, "Irlanda"),
            new Translation(LanguageCode.JA, "アイルランド"),
            new Translation(LanguageCode.KA, "ირლანდია"),
            new Translation(LanguageCode.KK, "Ирландия"),
            new Translation(LanguageCode.KO, "아일랜드"),
            new Translation(LanguageCode.KY, "Ирландия"),
            new Translation(LanguageCode.LT, "Airija"),
            new Translation(LanguageCode.LV, "Īrija"),
            new Translation(LanguageCode.MK, "Ирска"),
            new Translation(LanguageCode.MN, "Ирланд"),
            new Translation(LanguageCode.NB, "Irland"),
            new Translation(LanguageCode.NL, "Ierland"),
            new Translation(LanguageCode.NN, "Irland"),
            new Translation(LanguageCode.PL, "Irlandia"),
            new Translation(LanguageCode.PT, "Irlanda"),
            new Translation(LanguageCode.RO, "Irlanda"),
            new Translation(LanguageCode.RU, "Ирландия"),
            new Translation(LanguageCode.SK, "Írsko"),
            new Translation(LanguageCode.SL, "Irska"),
            new Translation(LanguageCode.SR, "Ирска"),
            new Translation(LanguageCode.SV, "Irland"),
            new Translation(LanguageCode.TR, "İrlanda"),
            new Translation(LanguageCode.UK, "Ірландія"),
            new Translation(LanguageCode.UZ, "Irlandiya"),
            new Translation(LanguageCode.ZH, "爱尔兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IE;
        public Alpha3Code Alpha3Code => Alpha3Code.IRL;
        public int NumericCode => 372;
        public string[] TLD => new [] { ".ie" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.GB,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "353" };
    }
}
