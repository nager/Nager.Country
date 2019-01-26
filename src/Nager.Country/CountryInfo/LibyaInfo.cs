namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Libya
	/// </summary>
	public class LibyaInfo : ICountryInfo
	{
		public string CommonName => "Libya";
		public string OfficialName => "State of Libya";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "ليبيا"),
			new Translation(LanguageCode.AZ, "Liviya"),
			new Translation(LanguageCode.BE, "Лівія"),
			new Translation(LanguageCode.BG, "Либия"),
			new Translation(LanguageCode.BS, "Libija"),
			new Translation(LanguageCode.CA, "Líbia"),
			new Translation(LanguageCode.CS, "Libye"),
			new Translation(LanguageCode.DA, "Libyen"),
			new Translation(LanguageCode.DE, "Libyen"),
			new Translation(LanguageCode.EL, "Κράτος της Λιβύης"),
			new Translation(LanguageCode.EN, "Libya"),
			new Translation(LanguageCode.ES, "Libia"),
			new Translation(LanguageCode.ET, "Liibüa"),
			new Translation(LanguageCode.FA, "لیبی"),
			new Translation(LanguageCode.FI, "Libya"),
			new Translation(LanguageCode.FR, "Libye"),
			new Translation(LanguageCode.HE, "לוב"),
			new Translation(LanguageCode.HR, "Libija"),
			new Translation(LanguageCode.HU, "Líbia"),
			new Translation(LanguageCode.HY, "Լիբիա"),
			new Translation(LanguageCode.ID, "Libya"),
			new Translation(LanguageCode.IT, "Libia"),
			new Translation(LanguageCode.JA, "リビア"),
			new Translation(LanguageCode.KA, "ლიბია"),
			new Translation(LanguageCode.KK, "Ливия"),
			new Translation(LanguageCode.KO, "리비아 아랍 자 마히리 야"),
			new Translation(LanguageCode.KY, "Ливия"),
			new Translation(LanguageCode.LT, "Libija"),
			new Translation(LanguageCode.LV, "Lībija"),
			new Translation(LanguageCode.MK, "Либија"),
			new Translation(LanguageCode.MN, "Ливи"),
			new Translation(LanguageCode.NB, "Libya"),
			new Translation(LanguageCode.NL, "Libië"),
			new Translation(LanguageCode.NN, "Libya"),
			new Translation(LanguageCode.PL, "Libia"),
			new Translation(LanguageCode.PT, "Líbia"),
			new Translation(LanguageCode.RO, "Libia"),
			new Translation(LanguageCode.RU, "Ливия"),
			new Translation(LanguageCode.SK, "Líbya"),
			new Translation(LanguageCode.SL, "Libija"),
			new Translation(LanguageCode.SR, "Либија"),
			new Translation(LanguageCode.SV, "Libyen"),
			new Translation(LanguageCode.TR, "Libya"),
			new Translation(LanguageCode.UK, "Лівія"),
			new Translation(LanguageCode.UZ, "Liviya"),
			new Translation(LanguageCode.ZH, "利比亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.LY;
		public Alpha3Code Alpha3Code => Alpha3Code.LBY;
		public int NumericCode => 434;
		public string[] TLD => new [] { ".ly" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.TD,
			Alpha2Code.EG,
			Alpha2Code.NE,
			Alpha2Code.SD,
			Alpha2Code.TN,
		};

		public string[] Currencies => new [] { "LYD" };
		public string[] CallingCodes => new [] { "218" };
	}
}
