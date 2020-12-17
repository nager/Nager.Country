namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Åland Islands
    /// </summary>
    public class AlandIslandsInfo : ICountryInfo
    {
        public string CommonName => "Åland Islands";
        public string OfficialName => "Åland Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر أولاند"),
            new Translation(LanguageCode.AZ, "Aland adaları"),
            new Translation(LanguageCode.BE, "Аландскія астравы"),
            new Translation(LanguageCode.BG, "Оландски острови"),
            new Translation(LanguageCode.BS, "Olandska Ostrva"),
            new Translation(LanguageCode.CA, "Åland, illes"),
            new Translation(LanguageCode.CS, "Ålandy"),
            new Translation(LanguageCode.DA, "Ålandsøerne"),
            new Translation(LanguageCode.DE, "Åland"),
            new Translation(LanguageCode.EL, "Νήσοι Ώλαντ"),
            new Translation(LanguageCode.EN, "Åland Islands"),
            new Translation(LanguageCode.ES, "Islas Åland"),
            new Translation(LanguageCode.ET, "Ahvenamaa"),
            new Translation(LanguageCode.FA, "جزایر آلاند"),
            new Translation(LanguageCode.FI, "Ahvenanmaa"),
            new Translation(LanguageCode.FR, "Åland"),
            new Translation(LanguageCode.HE, "איי אולנד"),
            new Translation(LanguageCode.HR, "Ålandski otoci"),
            new Translation(LanguageCode.HU, "Åland"),
            new Translation(LanguageCode.HY, "Ալանդյան կղզիներ"),
            new Translation(LanguageCode.ID, "Åland Islands"),
            new Translation(LanguageCode.IT, "Isole Åland"),
            new Translation(LanguageCode.JA, "オーランド諸島"),
            new Translation(LanguageCode.KA, "ალანდის კუნძულები"),
            new Translation(LanguageCode.KK, "Аланд аралдары"),
            new Translation(LanguageCode.KO, "올란드 제도"),
            new Translation(LanguageCode.KY, "Аланд аралдары"),
            new Translation(LanguageCode.LT, "Alandų Salos"),
            new Translation(LanguageCode.LV, "Olandes salas"),
            new Translation(LanguageCode.MK, "Оландски Острови"),
            new Translation(LanguageCode.MN, "Аландын Арлууд"),
            new Translation(LanguageCode.NB, "Åland"),
            new Translation(LanguageCode.NL, "Åland"),
            new Translation(LanguageCode.NN, "Åland"),
            new Translation(LanguageCode.PL, "Wyspy Alandzkie"),
            new Translation(LanguageCode.PT, "Ilhas Åland"),
            new Translation(LanguageCode.RO, "Insulele Åland"),
            new Translation(LanguageCode.RU, "Аландские острова"),
            new Translation(LanguageCode.SK, "Alandy"),
            new Translation(LanguageCode.SL, "Ålandski otoki"),
            new Translation(LanguageCode.SR, "Оландска Острва"),
            new Translation(LanguageCode.SV, "Åland"),
            new Translation(LanguageCode.TR, "Åland Adaları"),
            new Translation(LanguageCode.UK, "Аландські острови"),
            new Translation(LanguageCode.UZ, "Aland orollari"),
            new Translation(LanguageCode.ZH, "奥兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AX;
        public Alpha3Code Alpha3Code => Alpha3Code.ALA;
        public int NumericCode => 248;
        public string[] TLD => new [] { ".ax" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "358" };
    }
}
