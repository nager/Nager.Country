namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Suriname
	/// </summary>
	public class SurinameInfo : ICountryInfo
	{
		public string CommonName => "Suriname";
		public string OfficialName => "Republic of Suriname";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "سورينام"),
			new Translation(LanguageCode.AZ, "Surinam"),
			new Translation(LanguageCode.BE, "Сурынам"),
			new Translation(LanguageCode.BG, "Суринам"),
			new Translation(LanguageCode.BS, "Surinam"),
			new Translation(LanguageCode.CA, "Surinam"),
			new Translation(LanguageCode.CS, "Surinam"),
			new Translation(LanguageCode.DA, "Surinam"),
			new Translation(LanguageCode.DE, "Suriname"),
			new Translation(LanguageCode.EL, "Σουρινάμ"),
			new Translation(LanguageCode.EN, "Suriname"),
			new Translation(LanguageCode.ES, "Suriname"),
			new Translation(LanguageCode.ET, "Suriname"),
			new Translation(LanguageCode.FA, "سورینام"),
			new Translation(LanguageCode.FI, "Suriname"),
			new Translation(LanguageCode.FR, "Suriname"),
			new Translation(LanguageCode.HE, "סורינם"),
			new Translation(LanguageCode.HR, "Surinam"),
			new Translation(LanguageCode.HU, "Suriname"),
			new Translation(LanguageCode.HY, "Սուրինամ"),
			new Translation(LanguageCode.ID, "Suriname"),
			new Translation(LanguageCode.IT, "Suriname"),
			new Translation(LanguageCode.JA, "スリナム"),
			new Translation(LanguageCode.KA, "სურინამი"),
			new Translation(LanguageCode.KK, "Суринам"),
			new Translation(LanguageCode.KO, "수리남"),
			new Translation(LanguageCode.KY, "Суринаме"),
			new Translation(LanguageCode.LT, "Surinamas"),
			new Translation(LanguageCode.LV, "Surinama"),
			new Translation(LanguageCode.MK, "Суринам"),
			new Translation(LanguageCode.MN, "Суринам"),
			new Translation(LanguageCode.NB, "Surinam"),
			new Translation(LanguageCode.NL, "Suriname"),
			new Translation(LanguageCode.NN, "Surinam"),
			new Translation(LanguageCode.PL, "Surinam"),
			new Translation(LanguageCode.PT, "Suriname"),
			new Translation(LanguageCode.RO, "Suriname"),
			new Translation(LanguageCode.RU, "Суринам"),
			new Translation(LanguageCode.SK, "Surinam"),
			new Translation(LanguageCode.SL, "Surinam"),
			new Translation(LanguageCode.SR, "Суринам"),
			new Translation(LanguageCode.SV, "Surinam"),
			new Translation(LanguageCode.TR, "Surinam"),
			new Translation(LanguageCode.UK, "Суринам"),
			new Translation(LanguageCode.UZ, "Surinam"),
			new Translation(LanguageCode.ZH, "苏里南"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.SR;
		public Alpha3Code Alpha3Code => Alpha3Code.SUR;
		public int NumericCode => 740;
		public string[] TLD => new [] { ".sr" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.GF,
			Alpha2Code.GY,
		};

		public string[] Currencies => new [] { "SRD" };
		public string[] CallingCodes => new [] { "597" };
	}
}
