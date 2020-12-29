using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montenegro
    /// </summary>
    public class MontenegroInfo : ICountryInfo
    {
        public string CommonName => "Montenegro";
        public string OfficialName => "Montenegro";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الجبل الأسود"),
            new Translation(LanguageCode.AZ, "Monteneqro"),
            new Translation(LanguageCode.BE, "Чарнагорыя"),
            new Translation(LanguageCode.BG, "Черна гора"),
            new Translation(LanguageCode.BS, "Crna Gora"),
            new Translation(LanguageCode.CA, "Montenegro"),
            new Translation(LanguageCode.CS, "Černá Hora"),
            new Translation(LanguageCode.DA, "Montenegro"),
            new Translation(LanguageCode.DE, "Montenegro"),
            new Translation(LanguageCode.EL, "Μαυροβούνιο"),
            new Translation(LanguageCode.EN, "Montenegro"),
            new Translation(LanguageCode.ES, "Montenegro"),
            new Translation(LanguageCode.ET, "Montenegro"),
            new Translation(LanguageCode.FA, "مونته‌نگرو"),
            new Translation(LanguageCode.FI, "Montenegro"),
            new Translation(LanguageCode.FR, "Monténégro"),
            new Translation(LanguageCode.HE, "מונטנגרו"),
            new Translation(LanguageCode.HR, "Crna Gora"),
            new Translation(LanguageCode.HU, "Montenegró"),
            new Translation(LanguageCode.HY, "Չեռնոգորիա"),
            new Translation(LanguageCode.ID, "Montenegro"),
            new Translation(LanguageCode.IT, "Montenegro"),
            new Translation(LanguageCode.JA, "モンテネグロ"),
            new Translation(LanguageCode.KA, "მონტენეგრო"),
            new Translation(LanguageCode.KK, "Черногория"),
            new Translation(LanguageCode.KO, "몬테네그로"),
            new Translation(LanguageCode.KY, "Черногория"),
            new Translation(LanguageCode.LT, "Juodkalnija"),
            new Translation(LanguageCode.LV, "Melnkalne"),
            new Translation(LanguageCode.MK, "Црна Гора"),
            new Translation(LanguageCode.MN, "Монтенегро"),
            new Translation(LanguageCode.NB, "Montenegro"),
            new Translation(LanguageCode.NL, "Montenegro"),
            new Translation(LanguageCode.NN, "Montenegro"),
            new Translation(LanguageCode.PL, "Czarnogóra"),
            new Translation(LanguageCode.PT, "Montenegro"),
            new Translation(LanguageCode.RO, "Muntenegru"),
            new Translation(LanguageCode.RU, "Черногория"),
            new Translation(LanguageCode.SK, "Čierna Hora"),
            new Translation(LanguageCode.SL, "Črna gora"),
            new Translation(LanguageCode.SR, "Црна Гора"),
            new Translation(LanguageCode.SV, "Montenegro"),
            new Translation(LanguageCode.TR, "Karadağ"),
            new Translation(LanguageCode.UK, "Чорногорія"),
            new Translation(LanguageCode.UZ, "Chernogoriya"),
            new Translation(LanguageCode.ZH, "蒙特内哥罗"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ME;
        public Alpha3Code Alpha3Code => Alpha3Code.MNE;
        public int NumericCode => 499;
        public string[] TLD => new [] { ".me" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BA,
            Alpha2Code.HR,
            Alpha2Code.RS,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "382" };
    }
}
