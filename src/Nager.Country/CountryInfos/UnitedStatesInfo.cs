using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States
    /// </summary>
    public class UnitedStatesInfo : ICountryInfo
    {
        public string CommonName => "United States";
        public string OfficialName => "United States of America";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الولايات المتحدة"),
            new Translation(LanguageCode.AZ, "Amerika Birləşmiş Ştatları"),
            new Translation(LanguageCode.BE, "Злучаныя Штаты Амерыкі"),
            new Translation(LanguageCode.BG, "Съединени щати"),
            new Translation(LanguageCode.BS, "Sjedinjene Američke Države"),
            new Translation(LanguageCode.CA, "Estats Units (EUA)"),
            new Translation(LanguageCode.CS, "Spojené státy americké"),
            new Translation(LanguageCode.DA, "USA"),
            new Translation(LanguageCode.DE, "Vereinigte Staaten von Amerika"),
            new Translation(LanguageCode.EL, "Ηνωμένες Πολιτείες Αμερικής"),
            new Translation(LanguageCode.EN, "United States of America"),
            new Translation(LanguageCode.ES, "Estados Unidos"),
            new Translation(LanguageCode.ET, "Ameerika Ühendriigid"),
            new Translation(LanguageCode.FA, "ایالات متحده"),
            new Translation(LanguageCode.FI, "Yhdysvallat"),
            new Translation(LanguageCode.FR, "États-Unis d'Amérique"),
            new Translation(LanguageCode.HE, "ארצות הברית"),
            new Translation(LanguageCode.HR, "Sjedinjene Američke Države"),
            new Translation(LanguageCode.HU, "Amerikai Egyesült Államok"),
            new Translation(LanguageCode.HY, "Միացյալ Նահանգներ"),
            new Translation(LanguageCode.ID, "Amerika Serikat"),
            new Translation(LanguageCode.IT, "Stati Uniti d'America"),
            new Translation(LanguageCode.JA, "アメリカ合衆国"),
            new Translation(LanguageCode.KA, "ამერიკის შეერთებული შტატები"),
            new Translation(LanguageCode.KK, "Америка Құрама Штаттары"),
            new Translation(LanguageCode.KO, "미국"),
            new Translation(LanguageCode.KY, "Америка Кошмо Штаттары"),
            new Translation(LanguageCode.LT, "Jungtinės Valstijos"),
            new Translation(LanguageCode.LV, "Amerikas Savienotās Valstis"),
            new Translation(LanguageCode.MK, "Соединети Американски Држави"),
            new Translation(LanguageCode.MN, "Америкийн Нэгдсэн Улс"),
            new Translation(LanguageCode.NB, "USA"),
            new Translation(LanguageCode.NL, "Verenigde Staten van Amerika"),
            new Translation(LanguageCode.NN, "USA"),
            new Translation(LanguageCode.PL, "Stany Zjednoczone"),
            new Translation(LanguageCode.PT, "Estados Unidos"),
            new Translation(LanguageCode.RO, "Statele Unite ale Americii"),
            new Translation(LanguageCode.RU, "США"),
            new Translation(LanguageCode.SK, "Spojené štáty"),
            new Translation(LanguageCode.SL, "Združene države Amerike"),
            new Translation(LanguageCode.SR, "Сједињене Државе"),
            new Translation(LanguageCode.SV, "USA"),
            new Translation(LanguageCode.TR, "ABD"),
            new Translation(LanguageCode.UK, "США"),
            new Translation(LanguageCode.UZ, "Amerika Qo‘shma Shtatlari"),
            new Translation(LanguageCode.ZH, "美国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.US;
        public Alpha3Code Alpha3Code => Alpha3Code.USA;
        public int NumericCode => 840;
        public string[] TLD => new [] { ".us" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CA,
            Alpha2Code.MX,
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1" };
    }
}
