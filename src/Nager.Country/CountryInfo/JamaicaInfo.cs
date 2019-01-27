namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Jamaica
    /// </summary>
    public class JamaicaInfo : ICountryInfo
    {
        public string CommonName => "Jamaica";
        public string OfficialName => "Jamaica";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جامايكا"),
            new Translation(LanguageCode.AZ, "Yamayka"),
            new Translation(LanguageCode.BE, "Ямайка"),
            new Translation(LanguageCode.BG, "Ямайка"),
            new Translation(LanguageCode.BS, "Jamajka"),
            new Translation(LanguageCode.CA, "Jamaica"),
            new Translation(LanguageCode.CS, "Jamajka"),
            new Translation(LanguageCode.DA, "Jamaica"),
            new Translation(LanguageCode.DE, "Jamaika"),
            new Translation(LanguageCode.EL, "Τζαμάικα"),
            new Translation(LanguageCode.EN, "Jamaica"),
            new Translation(LanguageCode.ES, "Jamaica"),
            new Translation(LanguageCode.ET, "Jamaica"),
            new Translation(LanguageCode.FA, "جامائیکا"),
            new Translation(LanguageCode.FI, "Jamaika"),
            new Translation(LanguageCode.FR, "Jamaïque"),
            new Translation(LanguageCode.HE, "ג׳מייקה"),
            new Translation(LanguageCode.HR, "Jamajka"),
            new Translation(LanguageCode.HU, "Jamaica"),
            new Translation(LanguageCode.HY, "Ճամայկա"),
            new Translation(LanguageCode.ID, "Jamaika"),
            new Translation(LanguageCode.IT, "Giamaica"),
            new Translation(LanguageCode.JA, "ジャマイカ"),
            new Translation(LanguageCode.KA, "იამაიკა"),
            new Translation(LanguageCode.KK, "Ямайка"),
            new Translation(LanguageCode.KO, "자메이카"),
            new Translation(LanguageCode.KY, "Ямайка"),
            new Translation(LanguageCode.LT, "Jamaika"),
            new Translation(LanguageCode.LV, "Jamaika"),
            new Translation(LanguageCode.MK, "Јамајка"),
            new Translation(LanguageCode.MN, "Ямайк"),
            new Translation(LanguageCode.NB, "Jamaica"),
            new Translation(LanguageCode.NL, "Jamaica"),
            new Translation(LanguageCode.NN, "Jamaica"),
            new Translation(LanguageCode.PL, "Jamajka"),
            new Translation(LanguageCode.PT, "Jamaica"),
            new Translation(LanguageCode.RO, "Jamaica"),
            new Translation(LanguageCode.RU, "Ямайка"),
            new Translation(LanguageCode.SK, "Jamajka"),
            new Translation(LanguageCode.SL, "Jamajka"),
            new Translation(LanguageCode.SR, "Јамајка"),
            new Translation(LanguageCode.SV, "Jamaica"),
            new Translation(LanguageCode.TR, "Jamaika"),
            new Translation(LanguageCode.UK, "Ямайка"),
            new Translation(LanguageCode.UZ, "Yamayka"),
            new Translation(LanguageCode.ZH, "牙买加"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.JM;
        public Alpha3Code Alpha3Code => Alpha3Code.JAM;
        public int NumericCode => 388;
        public string[] TLD => new [] { ".jm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "JMD" };
        public string[] CallingCodes => new [] { "1876" };
    }
}
