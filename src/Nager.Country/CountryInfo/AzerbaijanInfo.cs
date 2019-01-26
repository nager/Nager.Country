namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Azerbaijan
	/// </summary>
	public class AzerbaijanInfo : ICountryInfo
	{
		public string CommonName => "Azerbaijan";
        public string OfficialName => "Republic of Azerbaijan";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "أذربيجان"),
			new Translation(LanguageCode.AZ, "Azərbaycan"),
			new Translation(LanguageCode.BE, "Азербайджан"),
			new Translation(LanguageCode.BG, "Азербайджан"),
			new Translation(LanguageCode.BS, "Azerbejdžan"),
			new Translation(LanguageCode.CA, "Azerbaidjan"),
			new Translation(LanguageCode.CS, "Ázerbájdžán"),
			new Translation(LanguageCode.DA, "Aserbajdsjan"),
			new Translation(LanguageCode.DE, "Aserbaidschan"),
			new Translation(LanguageCode.EL, "Αζερμπαϊτζάν"),
			new Translation(LanguageCode.EN, "Azerbaijan"),
			new Translation(LanguageCode.ES, "Azerbaiyán"),
			new Translation(LanguageCode.ET, "Aserbaidžaan"),
			new Translation(LanguageCode.FA, "جمهوری آذربایجان"),
			new Translation(LanguageCode.FI, "Azerbaidžan"),
			new Translation(LanguageCode.FR, "Azerbaidjan"),
			new Translation(LanguageCode.HE, "אזרבייג׳ן"),
			new Translation(LanguageCode.HR, "Azerbajdžan"),
			new Translation(LanguageCode.HU, "Azerbajdzsán"),
			new Translation(LanguageCode.HY, "Ադրբեջան"),
			new Translation(LanguageCode.ID, "Azerbaijan"),
			new Translation(LanguageCode.IT, "Azerbaigian"),
			new Translation(LanguageCode.JA, "アゼルバイジャン"),
			new Translation(LanguageCode.KA, "აზერბაიჯანი"),
			new Translation(LanguageCode.KK, "Әзірбайжан"),
			new Translation(LanguageCode.KO, "아제르바이잔"),
			new Translation(LanguageCode.KY, "Азербайжан"),
			new Translation(LanguageCode.LT, "Azerbaidžanas"),
			new Translation(LanguageCode.LV, "Azerbaidžāna"),
			new Translation(LanguageCode.MK, "Азербејџан"),
			new Translation(LanguageCode.MN, "Азербайжан"),
			new Translation(LanguageCode.NB, "Aserbajdsjan"),
			new Translation(LanguageCode.NL, "Azerbeidzjan"),
			new Translation(LanguageCode.NN, "Aserbajdsjan"),
			new Translation(LanguageCode.PL, "Azerbejdżan"),
			new Translation(LanguageCode.PT, "Azerbaijão"),
			new Translation(LanguageCode.RO, "Azerbaidjan"),
			new Translation(LanguageCode.RU, "Азербайджан"),
			new Translation(LanguageCode.SK, "Azerbajdžan"),
			new Translation(LanguageCode.SL, "Azerbajdžan"),
			new Translation(LanguageCode.SR, "Азербејџан"),
			new Translation(LanguageCode.SV, "Azerbajdzjan"),
			new Translation(LanguageCode.TR, "Azerbaycan"),
			new Translation(LanguageCode.UK, "Азербайджан"),
			new Translation(LanguageCode.UZ, "Ozarbayjon"),
			new Translation(LanguageCode.ZH, "阿塞拜疆"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.AZ;
		public Alpha3Code Alpha3Code => Alpha3Code.AZE;
		public int NumericCode => 031;
		public string[] TLD => new [] { ".az" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AM,
			Alpha2Code.GE,
			Alpha2Code.IR,
			Alpha2Code.RU,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "AZN" };
		public string[] CallingCodes => new [] { "994" };
	}
}
