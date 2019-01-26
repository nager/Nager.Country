namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nepal
	/// </summary>
	public class NepalInfo : ICountryInfo
	{
		public string CommonName => "Nepal";
		public string OfficialName => "Federal Democratic Republic of Nepal";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "نيبال"),
			new Translation(LanguageCode.AZ, "Nepal"),
			new Translation(LanguageCode.BE, "Непал"),
			new Translation(LanguageCode.BG, "Непал"),
			new Translation(LanguageCode.BS, "Nepal"),
			new Translation(LanguageCode.CA, "Nepal"),
			new Translation(LanguageCode.CS, "Nepál"),
			new Translation(LanguageCode.DA, "Nepal"),
			new Translation(LanguageCode.DE, "Nepal"),
			new Translation(LanguageCode.EL, "Νεπάλ"),
			new Translation(LanguageCode.EN, "Nepal"),
			new Translation(LanguageCode.ES, "Nepal"),
			new Translation(LanguageCode.ET, "Nepal"),
			new Translation(LanguageCode.FA, "نپال"),
			new Translation(LanguageCode.FI, "Nepal"),
			new Translation(LanguageCode.FR, "Népal"),
			new Translation(LanguageCode.HE, "נפאל"),
			new Translation(LanguageCode.HR, "Nepal"),
			new Translation(LanguageCode.HU, "Nepál"),
			new Translation(LanguageCode.HY, "Նեպալ"),
			new Translation(LanguageCode.ID, "Nepal"),
			new Translation(LanguageCode.IT, "Nepal"),
			new Translation(LanguageCode.JA, "ネパール"),
			new Translation(LanguageCode.KA, "ნეპალი"),
			new Translation(LanguageCode.KK, "Непал"),
			new Translation(LanguageCode.KO, "네팔"),
			new Translation(LanguageCode.KY, "Непал"),
			new Translation(LanguageCode.LT, "Nepalas"),
			new Translation(LanguageCode.LV, "Nepāla"),
			new Translation(LanguageCode.MK, "Непал"),
			new Translation(LanguageCode.MN, "Балба"),
			new Translation(LanguageCode.NB, "Nepal"),
			new Translation(LanguageCode.NL, "Nepal"),
			new Translation(LanguageCode.NN, "Nepal"),
			new Translation(LanguageCode.PL, "Nepal"),
			new Translation(LanguageCode.PT, "Nepal"),
			new Translation(LanguageCode.RO, "Nepal"),
			new Translation(LanguageCode.RU, "Непал"),
			new Translation(LanguageCode.SK, "Nepál"),
			new Translation(LanguageCode.SL, "Nepal"),
			new Translation(LanguageCode.SR, "Непал"),
			new Translation(LanguageCode.SV, "Nepal"),
			new Translation(LanguageCode.TR, "Nepal"),
			new Translation(LanguageCode.UK, "Непал"),
			new Translation(LanguageCode.UZ, "Nepal"),
			new Translation(LanguageCode.ZH, "尼泊尔"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.NP;
		public Alpha3Code Alpha3Code => Alpha3Code.NPL;
		public int NumericCode => 524;
		public string[] TLD => new [] { ".np" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthernAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
			Alpha2Code.IN,
		};

		public string[] Currencies => new [] { "NPR" };
		public string[] CallingCodes => new [] { "977" };
	}
}
