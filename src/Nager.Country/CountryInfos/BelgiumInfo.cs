using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belgium
    /// </summary>
    public class BelgiumInfo : ICountryInfo
    {
        public string CommonName => "Belgium";
        public string OfficialName => "Kingdom of Belgium";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بلجيكا"),
            new Translation(LanguageCode.AZ, "Belçika"),
            new Translation(LanguageCode.BE, "Бельгія"),
            new Translation(LanguageCode.BG, "Белгия"),
            new Translation(LanguageCode.BS, "Belgija"),
            new Translation(LanguageCode.CA, "Bèlgica"),
            new Translation(LanguageCode.CS, "Belgie"),
            new Translation(LanguageCode.DA, "Belgien"),
            new Translation(LanguageCode.DE, "Belgien"),
            new Translation(LanguageCode.EL, "Βέλγιο"),
            new Translation(LanguageCode.EN, "Belgium"),
            new Translation(LanguageCode.ES, "Bélgica"),
            new Translation(LanguageCode.ET, "Belgia"),
            new Translation(LanguageCode.FA, "بلژیک"),
            new Translation(LanguageCode.FI, "Belgia"),
            new Translation(LanguageCode.FR, "Belgique"),
            new Translation(LanguageCode.HE, "בלגיה"),
            new Translation(LanguageCode.HR, "Belgija"),
            new Translation(LanguageCode.HU, "Belgium"),
            new Translation(LanguageCode.HY, "Բելգիա"),
            new Translation(LanguageCode.ID, "Belgia"),
            new Translation(LanguageCode.IT, "Belgio"),
            new Translation(LanguageCode.JA, "ベルギー"),
            new Translation(LanguageCode.KA, "ბელგია"),
            new Translation(LanguageCode.KK, "Бельгия"),
            new Translation(LanguageCode.KO, "벨기에"),
            new Translation(LanguageCode.KY, "Бельгия"),
            new Translation(LanguageCode.LT, "Belgija"),
            new Translation(LanguageCode.LV, "Beļģija"),
            new Translation(LanguageCode.MK, "Белгија"),
            new Translation(LanguageCode.MN, "Белги"),
            new Translation(LanguageCode.NB, "Belgia"),
            new Translation(LanguageCode.NL, "België"),
            new Translation(LanguageCode.NN, "Belgia"),
            new Translation(LanguageCode.PL, "Belgia"),
            new Translation(LanguageCode.PT, "Bélgica"),
            new Translation(LanguageCode.RO, "Belgia"),
            new Translation(LanguageCode.RU, "Бельгия"),
            new Translation(LanguageCode.SK, "Belgicko"),
            new Translation(LanguageCode.SL, "Belgija"),
            new Translation(LanguageCode.SR, "Белгија"),
            new Translation(LanguageCode.SV, "Belgien"),
            new Translation(LanguageCode.TR, "Belçika"),
            new Translation(LanguageCode.UK, "Бельгія"),
            new Translation(LanguageCode.UZ, "Belgiya"),
            new Translation(LanguageCode.ZH, "比利时"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BE;
        public Alpha3Code Alpha3Code => Alpha3Code.BEL;
        public int NumericCode => 056;
        public string[] TLD => new [] { ".be" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.DE,
            Alpha2Code.LU,
            Alpha2Code.NL,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "32" };
    }
}
