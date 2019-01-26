namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Niger
	/// </summary>
	public class NigerInfo : ICountryInfo
	{
		public string CommonName => "Niger";
		public string OfficialName => "Republic of Niger";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "النيجر"),
			new Translation(LanguageCode.AZ, "Niger"),
			new Translation(LanguageCode.BE, "Нігер"),
			new Translation(LanguageCode.BG, "Нигер"),
			new Translation(LanguageCode.BS, "Niger"),
			new Translation(LanguageCode.CA, "Níger"),
			new Translation(LanguageCode.CS, "Niger"),
			new Translation(LanguageCode.DA, "Niger"),
			new Translation(LanguageCode.DE, "Niger"),
			new Translation(LanguageCode.EL, "Νίγηρας"),
			new Translation(LanguageCode.EN, "Niger"),
			new Translation(LanguageCode.ES, "Níger"),
			new Translation(LanguageCode.ET, "Niger"),
			new Translation(LanguageCode.FA, "نیجر"),
			new Translation(LanguageCode.FI, "Niger"),
			new Translation(LanguageCode.FR, "Niger"),
			new Translation(LanguageCode.HE, "ניז׳ר"),
			new Translation(LanguageCode.HR, "Niger"),
			new Translation(LanguageCode.HU, "Niger"),
			new Translation(LanguageCode.HY, "Նիգեր"),
			new Translation(LanguageCode.ID, "Niger"),
			new Translation(LanguageCode.IT, "Niger"),
			new Translation(LanguageCode.JA, "ニジェール"),
			new Translation(LanguageCode.KA, "ნიგერი"),
			new Translation(LanguageCode.KK, "Нигер"),
			new Translation(LanguageCode.KO, "니제르"),
			new Translation(LanguageCode.KY, "Нигер"),
			new Translation(LanguageCode.LT, "Nigeris"),
			new Translation(LanguageCode.LV, "Nigēra"),
			new Translation(LanguageCode.MK, "Нигер"),
			new Translation(LanguageCode.MN, "Нигер"),
			new Translation(LanguageCode.NB, "Niger"),
			new Translation(LanguageCode.NL, "Niger"),
			new Translation(LanguageCode.NN, "Niger"),
			new Translation(LanguageCode.PL, "Niger"),
			new Translation(LanguageCode.PT, "Níger"),
			new Translation(LanguageCode.RO, "Niger"),
			new Translation(LanguageCode.RU, "Нигер"),
			new Translation(LanguageCode.SK, "Niger"),
			new Translation(LanguageCode.SL, "Niger"),
			new Translation(LanguageCode.SR, "Нигер"),
			new Translation(LanguageCode.SV, "Niger"),
			new Translation(LanguageCode.TR, "Nijer"),
			new Translation(LanguageCode.UK, "Нігер"),
			new Translation(LanguageCode.UZ, "Niger"),
			new Translation(LanguageCode.ZH, "尼日尔"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.NE;
		public Alpha3Code Alpha3Code => Alpha3Code.NER;
		public int NumericCode => 562;
		public string[] TLD => new [] { ".ne" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.BJ,
			Alpha2Code.BF,
			Alpha2Code.TD,
			Alpha2Code.LY,
			Alpha2Code.ML,
			Alpha2Code.NG,
		};

		public string[] Currencies => new [] { "XOF" };
		public string[] CallingCodes => new [] { "227" };
	}
}
