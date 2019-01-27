namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Switzerland
    /// </summary>
    public class SwitzerlandInfo : ICountryInfo
    {
        public string CommonName => "Switzerland";
        public string OfficialName => "Swiss Confederation";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سويسرا"),
            new Translation(LanguageCode.AZ, "İsveçrə"),
            new Translation(LanguageCode.BE, "Швейцарыя"),
            new Translation(LanguageCode.BG, "Швейцария"),
            new Translation(LanguageCode.BS, "Švicarska"),
            new Translation(LanguageCode.CA, "Suïssa"),
            new Translation(LanguageCode.CS, "Švýcarsko"),
            new Translation(LanguageCode.DA, "Schweiz"),
            new Translation(LanguageCode.DE, "Schweiz"),
            new Translation(LanguageCode.EL, "Ελβετία"),
            new Translation(LanguageCode.EN, "Switzerland"),
            new Translation(LanguageCode.ES, "Suiza"),
            new Translation(LanguageCode.ET, "Šveits"),
            new Translation(LanguageCode.FA, "سوئیس"),
            new Translation(LanguageCode.FI, "Sveitsi"),
            new Translation(LanguageCode.FR, "Suisse"),
            new Translation(LanguageCode.HE, "שווייץ"),
            new Translation(LanguageCode.HR, "Švicarska"),
            new Translation(LanguageCode.HU, "Svájc"),
            new Translation(LanguageCode.HY, "Շվեյցարիա"),
            new Translation(LanguageCode.ID, "Swiss"),
            new Translation(LanguageCode.IT, "Svizzera"),
            new Translation(LanguageCode.JA, "スイス"),
            new Translation(LanguageCode.KA, "შვეიცარია"),
            new Translation(LanguageCode.KK, "Швейцария"),
            new Translation(LanguageCode.KO, "스위스"),
            new Translation(LanguageCode.KY, "Швейцария"),
            new Translation(LanguageCode.LT, "Šveicarija"),
            new Translation(LanguageCode.LV, "Šveice"),
            new Translation(LanguageCode.MK, "Швајцарија"),
            new Translation(LanguageCode.MN, "Швейцари"),
            new Translation(LanguageCode.NB, "Sveits"),
            new Translation(LanguageCode.NL, "Zwitserland"),
            new Translation(LanguageCode.NN, "Sveits"),
            new Translation(LanguageCode.PL, "Szwajcaria"),
            new Translation(LanguageCode.PT, "Suíça"),
            new Translation(LanguageCode.RO, "Elveția"),
            new Translation(LanguageCode.RU, "Швейцария"),
            new Translation(LanguageCode.SK, "Švajčiarsko"),
            new Translation(LanguageCode.SL, "Švica"),
            new Translation(LanguageCode.SR, "Швајцарска"),
            new Translation(LanguageCode.SV, "Schweiz"),
            new Translation(LanguageCode.TR, "İsviçre"),
            new Translation(LanguageCode.UK, "Швейцарія"),
            new Translation(LanguageCode.UZ, "Shveytsariya"),
            new Translation(LanguageCode.ZH, "瑞士"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CH;
        public Alpha3Code Alpha3Code => Alpha3Code.CHE;
        public int NumericCode => 756;
        public string[] TLD => new [] { ".ch" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.FR,
            Alpha2Code.IT,
            Alpha2Code.LI,
            Alpha2Code.DE,
        };

        public string[] Currencies => new [] { "CHE", "CHF", "CHW" };
        public string[] CallingCodes => new [] { "41" };
    }
}
