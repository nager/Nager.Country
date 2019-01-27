namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Portugal
    /// </summary>
    public class PortugalInfo : ICountryInfo
    {
        public string CommonName => "Portugal";
        public string OfficialName => "Portuguese Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "البرتغال"),
            new Translation(LanguageCode.AZ, "Portuqaliya"),
            new Translation(LanguageCode.BE, "Партугалія"),
            new Translation(LanguageCode.BG, "Португалия"),
            new Translation(LanguageCode.BS, "Portugal"),
            new Translation(LanguageCode.CA, "Portugal"),
            new Translation(LanguageCode.CS, "Portugalsko"),
            new Translation(LanguageCode.DA, "Portugal"),
            new Translation(LanguageCode.DE, "Portugal"),
            new Translation(LanguageCode.EL, "Πορτογαλία"),
            new Translation(LanguageCode.EN, "Portugal"),
            new Translation(LanguageCode.ES, "Portugal"),
            new Translation(LanguageCode.ET, "Portugal"),
            new Translation(LanguageCode.FA, "پرتغال"),
            new Translation(LanguageCode.FI, "Portugali"),
            new Translation(LanguageCode.FR, "Portugal"),
            new Translation(LanguageCode.HE, "פורטוגל"),
            new Translation(LanguageCode.HR, "Portugal"),
            new Translation(LanguageCode.HU, "Portugália"),
            new Translation(LanguageCode.HY, "Պորտուգալիա"),
            new Translation(LanguageCode.ID, "Portugal"),
            new Translation(LanguageCode.IT, "Portogallo"),
            new Translation(LanguageCode.JA, "ポルトガル"),
            new Translation(LanguageCode.KA, "პორტუგალია"),
            new Translation(LanguageCode.KK, "Португалия"),
            new Translation(LanguageCode.KO, "포르투갈"),
            new Translation(LanguageCode.KY, "Португалия"),
            new Translation(LanguageCode.LT, "Portugalija"),
            new Translation(LanguageCode.LV, "Portugāle"),
            new Translation(LanguageCode.MK, "Португалија"),
            new Translation(LanguageCode.MN, "Португаль"),
            new Translation(LanguageCode.NB, "Portugal"),
            new Translation(LanguageCode.NL, "Portugal"),
            new Translation(LanguageCode.NN, "Portugal"),
            new Translation(LanguageCode.PL, "Portugalia"),
            new Translation(LanguageCode.PT, "Portugal"),
            new Translation(LanguageCode.RO, "Portugalia"),
            new Translation(LanguageCode.RU, "Португалия"),
            new Translation(LanguageCode.SK, "Portugalsko"),
            new Translation(LanguageCode.SL, "Portugalska"),
            new Translation(LanguageCode.SR, "Португалија"),
            new Translation(LanguageCode.SV, "Portugal"),
            new Translation(LanguageCode.TR, "Portekiz"),
            new Translation(LanguageCode.UK, "Португалія"),
            new Translation(LanguageCode.UZ, "Portugaliya"),
            new Translation(LanguageCode.ZH, "葡萄牙"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PT;
        public Alpha3Code Alpha3Code => Alpha3Code.PRT;
        public int NumericCode => 620;
        public string[] TLD => new [] { ".pt" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.ES,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "351" };
    }
}
