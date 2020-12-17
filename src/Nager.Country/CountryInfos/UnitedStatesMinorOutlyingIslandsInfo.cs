namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    public class UnitedStatesMinorOutlyingIslandsInfo : ICountryInfo
    {
        public string CommonName => "United States Minor Outlying Islands";
        public string OfficialName => "United States Minor Outlying Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر الولايات المتحدة"),
            new Translation(LanguageCode.AZ, "ABŞ-a bağlı kiçik adacıqlar"),
            new Translation(LanguageCode.BE, "Малыя Аддаленыя астравы ЗША"),
            new Translation(LanguageCode.BG, "Отдалечени острови на САЩ"),
            new Translation(LanguageCode.BS, "Američka Vanjska Ostrva"),
            new Translation(LanguageCode.CA, "Illes Perifèriques Menors dels EUA"),
            new Translation(LanguageCode.CS, "Menší odlehlé ostrovy USA"),
            new Translation(LanguageCode.DA, "USA's ydre småøer"),
            new Translation(LanguageCode.DE, "United States Minor Outlying Islands"),
            new Translation(LanguageCode.EL, "Απομακρυσμένες Νησίδες των Ηνωμένων Πολιτειών"),
            new Translation(LanguageCode.EN, "United States Minor Outlying Islands"),
            new Translation(LanguageCode.ES, "Islas Ultramarinas Menores de los Estados Unidos"),
            new Translation(LanguageCode.ET, "Ühendriikide hajasaared"),
            new Translation(LanguageCode.FA, "جزایر دورافتادهٔ ایالات متحده"),
            new Translation(LanguageCode.FI, "Yhdysvaltain pienet erillissaaret"),
            new Translation(LanguageCode.FR, "Îles mineures éloignées des États-Unis"),
            new Translation(LanguageCode.HE, "האיים המרוחקים הקטנים של ארה״ב"),
            new Translation(LanguageCode.HR, "Mali udaljeni otoci SAD-a"),
            new Translation(LanguageCode.HU, "Az Amerikai Egyesült Államok lakatlan külbirtokai"),
            new Translation(LanguageCode.HY, "Արտաքին կղզիներ (ԱՄՆ)"),
            new Translation(LanguageCode.ID, "United States Minor Outlying Islands"),
            new Translation(LanguageCode.IT, "Isole minori esterne degli Stati Uniti"),
            new Translation(LanguageCode.JA, "合衆国領有小離島"),
            new Translation(LanguageCode.KA, "აშშ-ის შორეული კუნძულები"),
            new Translation(LanguageCode.KK, "АҚШ-тың сыртқы кіші аралдары"),
            new Translation(LanguageCode.KO, "미국령 군소 제도"),
            new Translation(LanguageCode.KY, "АКШнын сырткы аралдары"),
            new Translation(LanguageCode.LT, "Jungtinių Valstijų Mažosios Tolimosios Salos"),
            new Translation(LanguageCode.LV, "ASV Mazās Aizjūras salas"),
            new Translation(LanguageCode.MK, "Американски територии во Пацификот"),
            new Translation(LanguageCode.MN, "АНУ-ын тойрсон арлууд"),
            new Translation(LanguageCode.NB, "USA, mindre, utenforliggende øyer"),
            new Translation(LanguageCode.NL, "Ver afgelegen eilandjes van de Verenigde Staten"),
            new Translation(LanguageCode.NN, "USA, mindre, utanforliggande øyar"),
            new Translation(LanguageCode.PL, "Dalekie Wyspy Mniejsze Stanów Zjednoczonych"),
            new Translation(LanguageCode.PT, "Ilhas Distantes dos EUA"),
            new Translation(LanguageCode.RO, "Insulele Îndepărtate ale S.U.A."),
            new Translation(LanguageCode.RU, "Внешние малые острова (США)"),
            new Translation(LanguageCode.SK, "Menšie odľahlé ostrovy USA"),
            new Translation(LanguageCode.SL, "Stranski zunanji otoki Združenih držav"),
            new Translation(LanguageCode.SR, "Удаљена острва САД"),
            new Translation(LanguageCode.SV, "USA:s yttre öar"),
            new Translation(LanguageCode.TR, "ABD Uzak Adaları"),
            new Translation(LanguageCode.UK, "Зовнішні малі острови (США)"),
            new Translation(LanguageCode.UZ, "AQSH yondosh orollari"),
            new Translation(LanguageCode.ZH, "美国本土外小岛屿"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.UM;
        public Alpha3Code Alpha3Code => Alpha3Code.UMI;
        public int NumericCode => 581;
        public string[] TLD => new [] { ".us" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "USD" };
        public string[] CallingCodes => new string[0];
    }
}
