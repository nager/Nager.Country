using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sint Maarten
    /// </summary>
    public class SintMaartenInfo : ICountryInfo
    {
        public string CommonName => "Sint Maarten";
        public string OfficialName => "Sint Maarten";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سانت مارتن (الجزء الهولندي)"),
            new Translation(LanguageCode.AZ, "Sint-Marten"),
            new Translation(LanguageCode.BE, "Сінт-Мартэн"),
            new Translation(LanguageCode.BG, "Синт Мартен"),
            new Translation(LanguageCode.BS, "Sint Marten"),
            new Translation(LanguageCode.CA, "Sint Maarten"),
            new Translation(LanguageCode.CS, "Svatý Martin (nizozemská část)"),
            new Translation(LanguageCode.DA, "Saint Martin (hollandsk side)"),
            new Translation(LanguageCode.DE, "Sint Maarten"),
            new Translation(LanguageCode.EL, "Άγιος Μαρτίνος (Ολλανδία)"),
            new Translation(LanguageCode.EN, "Sint Maarten (Dutch part)"),
            new Translation(LanguageCode.ES, "Sint Maarten (neerlandesa)"),
            new Translation(LanguageCode.ET, "Sint Maarten"),
            new Translation(LanguageCode.FA, "سنت مارتن"),
            new Translation(LanguageCode.FI, "Sint Maarten"),
            new Translation(LanguageCode.FR, "Saint-Martin (partie néerlandaise)"),
            new Translation(LanguageCode.HE, "סנט מארטן"),
            new Translation(LanguageCode.HR, "Sint Maarten"),
            new Translation(LanguageCode.HU, "Szent Márton-sziget (holland rész)"),
            new Translation(LanguageCode.HY, "Սինտ Մարտեն"),
            new Translation(LanguageCode.ID, "Sint Maarten (Dutch part)"),
            new Translation(LanguageCode.IT, "Sint Maarten"),
            new Translation(LanguageCode.JA, "シント・マールテン（オランダ領）"),
            new Translation(LanguageCode.KA, "სინტ-მარტენი"),
            new Translation(LanguageCode.KK, "Синт-Мартен"),
            new Translation(LanguageCode.KO, "신트 마틴 (네덜란드어 부분)"),
            new Translation(LanguageCode.KY, "Синт Маартен"),
            new Translation(LanguageCode.LT, "Sint Martenas"),
            new Translation(LanguageCode.LV, "Sintmārtena"),
            new Translation(LanguageCode.MK, "Свети Мартин"),
            new Translation(LanguageCode.MN, "Синт Мартен"),
            new Translation(LanguageCode.NB, "Sint Maarten (Nederlandsk del)"),
            new Translation(LanguageCode.NL, "Sint Maarten (Nederlands deel)"),
            new Translation(LanguageCode.NN, "Sint Maarten (Nederlandsk del)"),
            new Translation(LanguageCode.PL, "Sint Maarten"),
            new Translation(LanguageCode.PT, "Sint Maarten"),
            new Translation(LanguageCode.RO, "Sint-Maarten"),
            new Translation(LanguageCode.RU, "Синт-Мартен"),
            new Translation(LanguageCode.SK, "Svätý Martin (hol.)"),
            new Translation(LanguageCode.SL, "Sint Maarten"),
            new Translation(LanguageCode.SR, "Свети Мартин (Холандија)"),
            new Translation(LanguageCode.SV, "Sint Maarten (nederländska delen)"),
            new Translation(LanguageCode.TR, "Sint Maarten"),
            new Translation(LanguageCode.UK, "Сінт-Мартен"),
            new Translation(LanguageCode.UZ, "Sint-Marten"),
            new Translation(LanguageCode.ZH, "荷属圣马丁"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SX;
        public Alpha3Code Alpha3Code => Alpha3Code.SXM;
        public int NumericCode => 534;
        public string[] TLD => new [] { ".sx" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.MF,
        };

        public ICurrency[] Currencies => new [] { new AngCurrency() };
        public string[] CallingCodes => new [] { "1721" };
    }
}
