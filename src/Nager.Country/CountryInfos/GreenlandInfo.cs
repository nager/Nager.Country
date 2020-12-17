namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Greenland
    /// </summary>
    public class GreenlandInfo : ICountryInfo
    {
        public string CommonName => "Greenland";
        public string OfficialName => "Greenland";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جرينلاند"),
            new Translation(LanguageCode.AZ, "Qrenlandiya"),
            new Translation(LanguageCode.BE, "Грэнландыя"),
            new Translation(LanguageCode.BG, "Гренландия"),
            new Translation(LanguageCode.BS, "Grenland"),
            new Translation(LanguageCode.CA, "Groenlàndia"),
            new Translation(LanguageCode.CS, "Grónsko"),
            new Translation(LanguageCode.DA, "Grønland"),
            new Translation(LanguageCode.DE, "Grönland"),
            new Translation(LanguageCode.EL, "Γροιλανδία"),
            new Translation(LanguageCode.EN, "Greenland"),
            new Translation(LanguageCode.ES, "Groenlandia"),
            new Translation(LanguageCode.ET, "Gröönimaa"),
            new Translation(LanguageCode.FA, "گرینلند"),
            new Translation(LanguageCode.FI, "Grönlanti"),
            new Translation(LanguageCode.FR, "Groenland"),
            new Translation(LanguageCode.HE, "גרינלנד"),
            new Translation(LanguageCode.HR, "Grenland"),
            new Translation(LanguageCode.HU, "Grönland"),
            new Translation(LanguageCode.HY, "Գրենլանդիա"),
            new Translation(LanguageCode.ID, "Greenland"),
            new Translation(LanguageCode.IT, "Groenlandia"),
            new Translation(LanguageCode.JA, "グリーンランド"),
            new Translation(LanguageCode.KA, "გრენლანდია"),
            new Translation(LanguageCode.KK, "Гренландия"),
            new Translation(LanguageCode.KO, "그린란드"),
            new Translation(LanguageCode.KY, "Гренландия"),
            new Translation(LanguageCode.LT, "Grenlandija"),
            new Translation(LanguageCode.LV, "Grenlande"),
            new Translation(LanguageCode.MK, "Гренланд"),
            new Translation(LanguageCode.MN, "Гренланд"),
            new Translation(LanguageCode.NB, "Grønland"),
            new Translation(LanguageCode.NL, "Groenland"),
            new Translation(LanguageCode.NN, "Grønland"),
            new Translation(LanguageCode.PL, "Grenlandia"),
            new Translation(LanguageCode.PT, "Groenlândia"),
            new Translation(LanguageCode.RO, "Groenlanda"),
            new Translation(LanguageCode.RU, "Гренландия"),
            new Translation(LanguageCode.SK, "Grónsko"),
            new Translation(LanguageCode.SL, "Grenlandija"),
            new Translation(LanguageCode.SR, "Гренланд"),
            new Translation(LanguageCode.SV, "Grönland"),
            new Translation(LanguageCode.TR, "Grönland"),
            new Translation(LanguageCode.UK, "Ґренландія"),
            new Translation(LanguageCode.UZ, "Grenlandiya"),
            new Translation(LanguageCode.ZH, "格陵兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GL;
        public Alpha3Code Alpha3Code => Alpha3Code.GRL;
        public int NumericCode => 304;
        public string[] TLD => new [] { ".gl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "DKK" };
        public string[] CallingCodes => new [] { "299" };
    }
}
