namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Isle of Man
    /// </summary>
    public class IsleofManInfo : ICountryInfo
    {
        public string CommonName => "Isle of Man";
        public string OfficialName => "Isle of Man";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزيرة مان"),
            new Translation(LanguageCode.AZ, "Men adası"),
            new Translation(LanguageCode.BE, "Востраў Мэн"),
            new Translation(LanguageCode.BG, "остров Ман"),
            new Translation(LanguageCode.BS, "Ostrvo Man"),
            new Translation(LanguageCode.CA, "Illa de Man"),
            new Translation(LanguageCode.CS, "Ostrov Man"),
            new Translation(LanguageCode.DA, "Isle of Man"),
            new Translation(LanguageCode.DE, "Insel Man"),
            new Translation(LanguageCode.EL, "Νήσος του Μαν"),
            new Translation(LanguageCode.EN, "Isle of Man"),
            new Translation(LanguageCode.ES, "Isla de Man"),
            new Translation(LanguageCode.ET, "Mani saar"),
            new Translation(LanguageCode.FA, "جزیرهٔ من"),
            new Translation(LanguageCode.FI, "Mansaari"),
            new Translation(LanguageCode.FR, "Île de Man"),
            new Translation(LanguageCode.HE, "האי מאן"),
            new Translation(LanguageCode.HR, "Otok Man"),
            new Translation(LanguageCode.HU, "Man-sziget"),
            new Translation(LanguageCode.HY, "Մեն կղզի"),
            new Translation(LanguageCode.ID, "Isle of Man"),
            new Translation(LanguageCode.IT, "Isola di Man"),
            new Translation(LanguageCode.JA, "マン島"),
            new Translation(LanguageCode.KA, "მენის კუნძული"),
            new Translation(LanguageCode.KK, "Мэн аралы"),
            new Translation(LanguageCode.KO, "아일 오브 맨"),
            new Translation(LanguageCode.KY, "Мэн аралы"),
            new Translation(LanguageCode.LT, "Meno Sala"),
            new Translation(LanguageCode.LV, "Mena"),
            new Translation(LanguageCode.MK, "Остров Ман"),
            new Translation(LanguageCode.MN, "Мэн Арал"),
            new Translation(LanguageCode.NB, "Man"),
            new Translation(LanguageCode.NL, "Man Eiland"),
            new Translation(LanguageCode.NN, "Man"),
            new Translation(LanguageCode.PL, "Wyspa Man"),
            new Translation(LanguageCode.PT, "Ilha de Man"),
            new Translation(LanguageCode.RO, "Insula Man"),
            new Translation(LanguageCode.RU, "Остров Мэн"),
            new Translation(LanguageCode.SK, "Ostrov Man"),
            new Translation(LanguageCode.SL, "Otok Man"),
            new Translation(LanguageCode.SR, "Острво Ман"),
            new Translation(LanguageCode.SV, "Isle of Man"),
            new Translation(LanguageCode.TR, "Man Adası"),
            new Translation(LanguageCode.UK, "Острів Мен"),
            new Translation(LanguageCode.UZ, "Men oroli"),
            new Translation(LanguageCode.ZH, "马恩岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IM;
        public Alpha3Code Alpha3Code => Alpha3Code.IMN;
        public int NumericCode => 833;
        public string[] TLD => new [] { ".im" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "GBP" };
        public string[] CallingCodes => new [] { "44" };
    }
}
