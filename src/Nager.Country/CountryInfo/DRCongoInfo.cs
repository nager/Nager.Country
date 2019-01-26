namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// DR Congo
	/// </summary>
	public class DRCongoInfo : ICountryInfo
	{
		public string CommonName => "DR Congo";
		public string OfficialName => "Democratic Republic of the Congo";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جمهورية الكونغو الديمقراطية"),
			new Translation(LanguageCode.AZ, "Konqo - Kinşasa"),
			new Translation(LanguageCode.BE, "Конга (Кіншаса)"),
			new Translation(LanguageCode.BG, "Конго (Киншаса)"),
			new Translation(LanguageCode.BS, "Demokratska Republika Kongo"),
			new Translation(LanguageCode.CA, "Congo, República Democràtica del"),
			new Translation(LanguageCode.CS, "Demokratická republika Kongo"),
			new Translation(LanguageCode.DA, "Demokratiske Republik Congo"),
			new Translation(LanguageCode.DE, "Kongo"),
			new Translation(LanguageCode.EL, "Λαϊκή Δημοκρατία του Κονγκό"),
			new Translation(LanguageCode.EN, "Congo, the Democratic Republic of the"),
			new Translation(LanguageCode.ES, "Congo (República Democrática del)"),
			new Translation(LanguageCode.ET, "Kongo DV"),
			new Translation(LanguageCode.FA, "کنگو - کینشاسا"),
			new Translation(LanguageCode.FI, "Kongon demokraattinen tasavalta"),
			new Translation(LanguageCode.FR, "Congo, République démocratique"),
			new Translation(LanguageCode.HE, "קונגו - קינשאסה"),
			new Translation(LanguageCode.HR, "Kongo - Kinshasa"),
			new Translation(LanguageCode.HU, "Kongói Demokratikus Köztársaság"),
			new Translation(LanguageCode.HY, "Կոնգո - Կինշասա"),
			new Translation(LanguageCode.ID, "Republik Demokratik Kongo"),
			new Translation(LanguageCode.IT, "Repubblica Democratica del Congo"),
			new Translation(LanguageCode.JA, "コンゴ民主共和国"),
			new Translation(LanguageCode.KA, "კონგო - კინშასა"),
			new Translation(LanguageCode.KK, "Конго"),
			new Translation(LanguageCode.KO, "콩고 민주 공화국"),
			new Translation(LanguageCode.KY, "Конго-Киншаса"),
			new Translation(LanguageCode.LT, "Kongas-Kinšasa"),
			new Translation(LanguageCode.LV, "Kongo (Kinšasa)"),
			new Translation(LanguageCode.MK, "Конго - Киншаса"),
			new Translation(LanguageCode.MN, "Конго-Киншаса"),
			new Translation(LanguageCode.NB, "Kongo"),
			new Translation(LanguageCode.NL, "Congo, Democratische Republiek"),
			new Translation(LanguageCode.NN, "Kongo"),
			new Translation(LanguageCode.PL, "Demokratyczna Republika Konga"),
			new Translation(LanguageCode.PT, "Congo - Kinshasa"),
			new Translation(LanguageCode.RO, "Congo - Kinshasa"),
			new Translation(LanguageCode.RU, "Демократическая Республика Конго"),
			new Translation(LanguageCode.SK, "Konžská demokratická republika"),
			new Translation(LanguageCode.SL, "Demokratična republika Kongo"),
			new Translation(LanguageCode.SR, "Конго - Киншаса"),
			new Translation(LanguageCode.SV, "Demokratiska republiken Kongo"),
			new Translation(LanguageCode.TR, "Kongo - Kinşasa"),
			new Translation(LanguageCode.UK, "Демократична Республіка Конго"),
			new Translation(LanguageCode.UZ, "Kongo – Kinshasa"),
			new Translation(LanguageCode.ZH, "刚果（金)"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.CD;
		public Alpha3Code Alpha3Code => Alpha3Code.COD;
		public int NumericCode => 180;
		public string[] TLD => new [] { ".cd" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AO,
			Alpha2Code.BI,
			Alpha2Code.CF,
			Alpha2Code.CG,
			Alpha2Code.RW,
			Alpha2Code.SS,
			Alpha2Code.TZ,
			Alpha2Code.UG,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "CDF" };
		public string[] CallingCodes => new [] { "243" };
	}
}
