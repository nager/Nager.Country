using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United Kingdom
    /// </summary>
    public class UnitedKingdomInfo : ICountryInfo
    {
        public string CommonName => "United Kingdom";
        public string OfficialName => "United Kingdom of Great Britain and Northern Ireland";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "المملكة المتحدة"),
            new Translation(LanguageCode.AZ, "Birləşmiş Krallıq"),
            new Translation(LanguageCode.BE, "Вялікабрытанія"),
            new Translation(LanguageCode.BG, "Обединеното кралство"),
            new Translation(LanguageCode.BS, "Velika Britanija"),
            new Translation(LanguageCode.CA, "Regne Unit"),
            new Translation(LanguageCode.CS, "Spojené království"),
            new Translation(LanguageCode.DA, "Storbritannien"),
            new Translation(LanguageCode.DE, "Vereinigtes Königreich"),
            new Translation(LanguageCode.EL, "Ηνωμένο Βασίλειο"),
            new Translation(LanguageCode.EN, "United Kingdom"),
            new Translation(LanguageCode.ES, "Reino Unido"),
            new Translation(LanguageCode.ET, "Suurbritannia"),
            new Translation(LanguageCode.FA, "بریتانیا"),
            new Translation(LanguageCode.FI, "Yhdistynyt kuningaskunta"),
            new Translation(LanguageCode.FR, "Royaume-Uni"),
            new Translation(LanguageCode.HE, "הממלכה המאוחדת"),
            new Translation(LanguageCode.HR, "Ujedinjeno Kraljevstvo"),
            new Translation(LanguageCode.HU, "Egyesült Királyság"),
            new Translation(LanguageCode.HY, "Միացյալ Թագավորություն"),
            new Translation(LanguageCode.ID, "Britania Raya"),
            new Translation(LanguageCode.IT, "Regno Unito"),
            new Translation(LanguageCode.JA, "イギリス"),
            new Translation(LanguageCode.KA, "გაერთიანებული სამეფო"),
            new Translation(LanguageCode.KK, "Ұлыбритания"),
            new Translation(LanguageCode.KO, "영국"),
            new Translation(LanguageCode.KY, "Улуу Британия"),
            new Translation(LanguageCode.LT, "Jungtinė Karalystė"),
            new Translation(LanguageCode.LV, "Lielbritānija"),
            new Translation(LanguageCode.MK, "Обединето Кралство"),
            new Translation(LanguageCode.MN, "Их Британи"),
            new Translation(LanguageCode.NB, "Storbritannia"),
            new Translation(LanguageCode.NL, "Verenigd Koninkrijk"),
            new Translation(LanguageCode.NN, "Storbritannia"),
            new Translation(LanguageCode.PL, "Wielka Brytania"),
            new Translation(LanguageCode.PT, "Reino Unido"),
            new Translation(LanguageCode.RO, "Regatul Unit"),
            new Translation(LanguageCode.RU, "Великобритания"),
            new Translation(LanguageCode.SK, "Spojené kráľovstvo"),
            new Translation(LanguageCode.SL, "Združeno kraljestvo"),
            new Translation(LanguageCode.SR, "Уједињено Краљевство"),
            new Translation(LanguageCode.SV, "Storbritannien"),
            new Translation(LanguageCode.TR, "Birleşik Krallık"),
            new Translation(LanguageCode.UK, "Великобританія"),
            new Translation(LanguageCode.UZ, "Buyuk Britaniya"),
            new Translation(LanguageCode.ZH, "英国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GB;
        public Alpha3Code Alpha3Code => Alpha3Code.GBR;
        public int NumericCode => 826;
        public string[] TLD => new [] { ".uk" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IE,
        };

        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        public string[] CallingCodes => new [] { "44" };
    }
}
