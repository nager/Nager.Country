namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United States Virgin Islands
	/// </summary>
	public class UnitedStatesVirginIslandsInfo : ICountryInfo
	{
		public string CommonName => "United States Virgin Islands";
		public string OfficialName => "Virgin Islands of the United States";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جزر العذراء الأمريكية"),
			new Translation(LanguageCode.AZ, "ABŞ Virgin adaları"),
			new Translation(LanguageCode.BE, "Амерыканскія Віргінскія астравы"),
			new Translation(LanguageCode.BG, "Американски Вирджински острови"),
			new Translation(LanguageCode.BS, "Američka Djevičanska Ostrva"),
			new Translation(LanguageCode.CA, "Verges Nord-americanes, illes"),
			new Translation(LanguageCode.CS, "Americké Panenské ostrovy"),
			new Translation(LanguageCode.DA, "Amerikanske Jomfruøer"),
			new Translation(LanguageCode.DE, "Amerikanische Jungferninseln"),
			new Translation(LanguageCode.EL, "Αμερικανικές Παρθένοι Νήσοι"),
			new Translation(LanguageCode.EN, "Virgin Islands, U.S."),
			new Translation(LanguageCode.ES, "Islas Vírgenes de los Estados Unidos"),
			new Translation(LanguageCode.ET, "USA Neitsisaared"),
			new Translation(LanguageCode.FA, "جزایر ویرجین ایالات متحده"),
			new Translation(LanguageCode.FI, "Yhdysvaltain Neitsytsaaret"),
			new Translation(LanguageCode.FR, "Îles vierges américaines"),
			new Translation(LanguageCode.HE, "איי הבתולה של ארצות הברית"),
			new Translation(LanguageCode.HR, "Američki Djevičanski otoci"),
			new Translation(LanguageCode.HU, "Amerikai Virgin-szigetek"),
			new Translation(LanguageCode.HY, "ԱՄՆ Վիրջինյան կղզիներ"),
			new Translation(LanguageCode.ID, "Virgin Islands, U.S."),
			new Translation(LanguageCode.IT, "Isole Vergini Americane"),
			new Translation(LanguageCode.JA, "アメリカ領ヴァージン諸島"),
			new Translation(LanguageCode.KA, "აშშ-ის ვირჯინის კუნძულები"),
			new Translation(LanguageCode.KK, "АҚШ-тың Виргин аралдары"),
			new Translation(LanguageCode.KO, "미국령 버진 아일랜드"),
			new Translation(LanguageCode.KY, "Виргин аралдары (АКШ)"),
			new Translation(LanguageCode.LT, "Jungtinių Valstijų Mergelių Salos"),
			new Translation(LanguageCode.LV, "ASV Virdžīnas"),
			new Translation(LanguageCode.MK, "Американски Девствени Острови"),
			new Translation(LanguageCode.MN, "АНУ-ын Виржиний Арлууд"),
			new Translation(LanguageCode.NB, "Jomfruøyene (USA)"),
			new Translation(LanguageCode.NL, "Maagdeneilanden, Amerikaanse"),
			new Translation(LanguageCode.NN, "Jomfruøyane (USA)"),
			new Translation(LanguageCode.PL, "Wyspy Dziewicze Stanów Zjednoczonych"),
			new Translation(LanguageCode.PT, "Ilhas Virgens dos EUA"),
			new Translation(LanguageCode.RO, "Insulele Virgine Americane"),
			new Translation(LanguageCode.RU, "Виргинские Острова (США)"),
			new Translation(LanguageCode.SK, "Americké Panenské ostrovy"),
			new Translation(LanguageCode.SL, "Ameriški Deviški otoki"),
			new Translation(LanguageCode.SR, "Америчка Девичанска Острва"),
			new Translation(LanguageCode.SV, "Amerikanska Jungfruöarna"),
			new Translation(LanguageCode.TR, "ABD Virjin Adaları"),
			new Translation(LanguageCode.UK, "Віргінські Острови (США)"),
			new Translation(LanguageCode.UZ, "AQSH Virgin orollari"),
			new Translation(LanguageCode.ZH, "美属维尔京群岛"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.VI;
		public Alpha3Code Alpha3Code => Alpha3Code.VIR;
		public int NumericCode => 850;
		public string[] TLD => new [] { ".vi" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1340" };
	}
}
