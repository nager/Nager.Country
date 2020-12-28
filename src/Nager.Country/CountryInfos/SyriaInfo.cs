using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Syria
    /// </summary>
    public class SyriaInfo : ICountryInfo
    {
        public string CommonName => "Syria";
        public string OfficialName => "Syrian Arab Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سوريا"),
            new Translation(LanguageCode.AZ, "Suriya"),
            new Translation(LanguageCode.BE, "Сірыя"),
            new Translation(LanguageCode.BG, "Сирия"),
            new Translation(LanguageCode.BS, "Sirija"),
            new Translation(LanguageCode.CA, "Síria"),
            new Translation(LanguageCode.CS, "Sýrie"),
            new Translation(LanguageCode.DA, "Syrien"),
            new Translation(LanguageCode.DE, "Syrien, Arabische Republik"),
            new Translation(LanguageCode.EL, "Αραβική Δημοκρατία της Συρίας"),
            new Translation(LanguageCode.EN, "Syrian Arab Republic"),
            new Translation(LanguageCode.ES, "República Árabe Siria"),
            new Translation(LanguageCode.ET, "Süüria"),
            new Translation(LanguageCode.FA, "سوریه"),
            new Translation(LanguageCode.FI, "Syyria"),
            new Translation(LanguageCode.FR, "Syrie"),
            new Translation(LanguageCode.HE, "סוריה"),
            new Translation(LanguageCode.HR, "Sirija"),
            new Translation(LanguageCode.HU, "Szíria"),
            new Translation(LanguageCode.HY, "Սիրիա"),
            new Translation(LanguageCode.ID, "Suriah"),
            new Translation(LanguageCode.IT, "Siria"),
            new Translation(LanguageCode.JA, "シリア・アラブ共和国"),
            new Translation(LanguageCode.KA, "სირია"),
            new Translation(LanguageCode.KK, "Сирия"),
            new Translation(LanguageCode.KO, "시리아"),
            new Translation(LanguageCode.KY, "Сирия"),
            new Translation(LanguageCode.LT, "Sirija"),
            new Translation(LanguageCode.LV, "Sīrija"),
            new Translation(LanguageCode.MK, "Сирија"),
            new Translation(LanguageCode.MN, "Сири"),
            new Translation(LanguageCode.NB, "Syria"),
            new Translation(LanguageCode.NL, "Syrië"),
            new Translation(LanguageCode.NN, "Syria"),
            new Translation(LanguageCode.PL, "Syria"),
            new Translation(LanguageCode.PT, "Síria"),
            new Translation(LanguageCode.RO, "Siria"),
            new Translation(LanguageCode.RU, "Сирия"),
            new Translation(LanguageCode.SK, "Sýria"),
            new Translation(LanguageCode.SL, "Sirija"),
            new Translation(LanguageCode.SR, "Сирија"),
            new Translation(LanguageCode.SV, "Syrien"),
            new Translation(LanguageCode.TR, "Suriye"),
            new Translation(LanguageCode.UK, "Сірія"),
            new Translation(LanguageCode.UZ, "Suriya"),
            new Translation(LanguageCode.ZH, "叙利亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SY;
        public Alpha3Code Alpha3Code => Alpha3Code.SYR;
        public int NumericCode => 760;
        public string[] TLD => new [] { ".sy", "سوريا." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new SypCurrency() };
        public string[] CallingCodes => new [] { "963" };
    }
}
