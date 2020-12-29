using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// São Tomé and Príncipe
    /// </summary>
    public class SaoTomeAndPrincipeInfo : ICountryInfo
    {
        public string CommonName => "São Tomé and Príncipe";
        public string OfficialName => "Democratic Republic of São Tomé and Príncipe";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ساو تومي وبرينسيب"),
            new Translation(LanguageCode.AZ, "San-Tome və Prinsipi"),
            new Translation(LanguageCode.BE, "Сан-Тамэ і Прынсіпі"),
            new Translation(LanguageCode.BG, "Сао Томе и Принсипи"),
            new Translation(LanguageCode.BS, "Sao Tome i Principe"),
            new Translation(LanguageCode.CA, "São Tomé i Príncipe"),
            new Translation(LanguageCode.CS, "Svatý Tomáš a Princův ostrov"),
            new Translation(LanguageCode.DA, "São Tomé og Príncipe"),
            new Translation(LanguageCode.DE, "São Tomé und Príncipe"),
            new Translation(LanguageCode.EL, "Σάο Τομέ και Πρίνσιπε"),
            new Translation(LanguageCode.EN, "Sao Tome and Principe"),
            new Translation(LanguageCode.ES, "Santo Tomé y Príncipe"),
            new Translation(LanguageCode.ET, "São Tomé ja Príncipe"),
            new Translation(LanguageCode.FA, "سائوتومه و پرینسیپ"),
            new Translation(LanguageCode.FI, "São Tomé ja Príncipe"),
            new Translation(LanguageCode.FR, "São Tomé et Principe"),
            new Translation(LanguageCode.HE, "סאו טומה ופרינסיפה"),
            new Translation(LanguageCode.HR, "Sveti Toma i Princip"),
            new Translation(LanguageCode.HU, "São Tomé és Príncipe"),
            new Translation(LanguageCode.HY, "Սան Տոմե և Փրինսիպի"),
            new Translation(LanguageCode.ID, "Sao Tome dan Principe"),
            new Translation(LanguageCode.IT, "São Tomé e Príncipe"),
            new Translation(LanguageCode.JA, "サントメ・プリンシペ"),
            new Translation(LanguageCode.KA, "სან-ტომე და პრინსიპი"),
            new Translation(LanguageCode.KK, "Сан-Томе және Принсипи"),
            new Translation(LanguageCode.KO, "상투 메 프린시 페"),
            new Translation(LanguageCode.KY, "Сан-Томе жана Принсипи"),
            new Translation(LanguageCode.LT, "San Tomė ir Prinsipė"),
            new Translation(LanguageCode.LV, "Santome un Prinsipi"),
            new Translation(LanguageCode.MK, "Сао Томе и Принсипе"),
            new Translation(LanguageCode.MN, "Сан-Томе ба Принсипи"),
            new Translation(LanguageCode.NB, "São Tomé og Príncipe"),
            new Translation(LanguageCode.NL, "São Tomé en Principe"),
            new Translation(LanguageCode.NN, "São Tomé og Príncipe"),
            new Translation(LanguageCode.PL, "Wyspy Świętego Tomasza i Książęca"),
            new Translation(LanguageCode.PT, "São Tomé e Príncipe"),
            new Translation(LanguageCode.RO, "Sao Tomé și Príncipe"),
            new Translation(LanguageCode.RU, "Сан-Томе и Принсипи"),
            new Translation(LanguageCode.SK, "Svätý Tomáš a Princov ostrov"),
            new Translation(LanguageCode.SL, "Sao Tome in Principe"),
            new Translation(LanguageCode.SR, "Сао Томе и Принципе"),
            new Translation(LanguageCode.SV, "São Tomé och Príncipe"),
            new Translation(LanguageCode.TR, "São Tomé ve Príncipe"),
            new Translation(LanguageCode.UK, "Сан-Томе і Принсіпі"),
            new Translation(LanguageCode.UZ, "San-Tome va Prinsipi"),
            new Translation(LanguageCode.ZH, "圣多美和普林西比"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ST;
        public Alpha3Code Alpha3Code => Alpha3Code.STP;
        public int NumericCode => 678;
        public string[] TLD => new [] { ".st" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] {new StdCurrency() };
        public string[] CallingCodes => new [] { "239" };
    }
}
