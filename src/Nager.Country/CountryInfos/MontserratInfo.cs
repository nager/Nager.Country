using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montserrat
    /// </summary>
    public class MontserratInfo : ICountryInfo
    {
        public string CommonName => "Montserrat";
        public string OfficialName => "Montserrat";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مونتسرات"),
            new Translation(LanguageCode.AZ, "Monserat"),
            new Translation(LanguageCode.BE, "Мантсерат"),
            new Translation(LanguageCode.BG, "Монтсерат"),
            new Translation(LanguageCode.BS, "Monserat"),
            new Translation(LanguageCode.CA, "Montserrat"),
            new Translation(LanguageCode.CS, "Montserrat"),
            new Translation(LanguageCode.DA, "Montserrat"),
            new Translation(LanguageCode.DE, "Montserrat"),
            new Translation(LanguageCode.EL, "Μοντσερράτ"),
            new Translation(LanguageCode.EN, "Montserrat"),
            new Translation(LanguageCode.ES, "Montserrat"),
            new Translation(LanguageCode.ET, "Montserrat"),
            new Translation(LanguageCode.FA, "مونت‌سرات"),
            new Translation(LanguageCode.FI, "Montserrat"),
            new Translation(LanguageCode.FR, "Montserrat"),
            new Translation(LanguageCode.HE, "מונסראט"),
            new Translation(LanguageCode.HR, "Montserrat"),
            new Translation(LanguageCode.HU, "Montserrat"),
            new Translation(LanguageCode.HY, "Մոնսեռատ"),
            new Translation(LanguageCode.ID, "Montserrat"),
            new Translation(LanguageCode.IT, "Montserrat"),
            new Translation(LanguageCode.JA, "モントセラト"),
            new Translation(LanguageCode.KA, "მონსერატი"),
            new Translation(LanguageCode.KK, "Монтсеррат"),
            new Translation(LanguageCode.KO, "몬세 라트"),
            new Translation(LanguageCode.KY, "Монсеррат"),
            new Translation(LanguageCode.LT, "Montseratas"),
            new Translation(LanguageCode.LV, "Montserrata"),
            new Translation(LanguageCode.MK, "Монсерат"),
            new Translation(LanguageCode.MN, "Монтсеррат"),
            new Translation(LanguageCode.NB, "Montserrat"),
            new Translation(LanguageCode.NL, "Montserrat"),
            new Translation(LanguageCode.NN, "Montserrat"),
            new Translation(LanguageCode.PL, "Montserrat"),
            new Translation(LanguageCode.PT, "Montserrat"),
            new Translation(LanguageCode.RO, "Montserrat"),
            new Translation(LanguageCode.RU, "Монтсеррат"),
            new Translation(LanguageCode.SK, "Montserrat"),
            new Translation(LanguageCode.SL, "Montserrat"),
            new Translation(LanguageCode.SR, "Монсерат"),
            new Translation(LanguageCode.SV, "Montserrat"),
            new Translation(LanguageCode.TR, "Montserrat"),
            new Translation(LanguageCode.UK, "Монтсеррат"),
            new Translation(LanguageCode.UZ, "Montserrat"),
            new Translation(LanguageCode.ZH, "蒙特塞拉特"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MS;
        public Alpha3Code Alpha3Code => Alpha3Code.MSR;
        public int NumericCode => 500;
        public string[] TLD => new [] { ".ms" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1664" };
    }
}
