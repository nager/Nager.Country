namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Lithuania
	/// </summary>
	public class LithuaniaInfo : ICountryInfo
	{
		public string CommonName => "Lithuania";
		public string OfficialName => "Republic of Lithuania";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "ليتوانيا"),
			new Translation(LanguageCode.AZ, "Litva"),
			new Translation(LanguageCode.BE, "Літва"),
			new Translation(LanguageCode.BG, "Литва"),
			new Translation(LanguageCode.BS, "Litvanija"),
			new Translation(LanguageCode.CA, "Lituània"),
			new Translation(LanguageCode.CS, "Litva"),
			new Translation(LanguageCode.DA, "Litauen"),
			new Translation(LanguageCode.DE, "Litauen"),
			new Translation(LanguageCode.EL, "Λιθουανία"),
			new Translation(LanguageCode.EN, "Lithuania"),
			new Translation(LanguageCode.ES, "Lituania"),
			new Translation(LanguageCode.ET, "Leedu"),
			new Translation(LanguageCode.FA, "لیتوانی"),
			new Translation(LanguageCode.FI, "Liettua"),
			new Translation(LanguageCode.FR, "Lituanie"),
			new Translation(LanguageCode.HE, "ליטא"),
			new Translation(LanguageCode.HR, "Litva"),
			new Translation(LanguageCode.HU, "Litvánia"),
			new Translation(LanguageCode.HY, "Լիտվա"),
			new Translation(LanguageCode.ID, "Lithuania"),
			new Translation(LanguageCode.IT, "Lituania"),
			new Translation(LanguageCode.JA, "リトアニア"),
			new Translation(LanguageCode.KA, "ლიტვა"),
			new Translation(LanguageCode.KK, "Литва"),
			new Translation(LanguageCode.KO, "리투아니아"),
			new Translation(LanguageCode.KY, "Литва"),
			new Translation(LanguageCode.LT, "Lietuva"),
			new Translation(LanguageCode.LV, "Lietuva"),
			new Translation(LanguageCode.MK, "Литванија"),
			new Translation(LanguageCode.MN, "Литва"),
			new Translation(LanguageCode.NB, "Litauen"),
			new Translation(LanguageCode.NL, "Litouwen"),
			new Translation(LanguageCode.NN, "Litauen"),
			new Translation(LanguageCode.PL, "Litwa"),
			new Translation(LanguageCode.PT, "Lituânia"),
			new Translation(LanguageCode.RO, "Lituania"),
			new Translation(LanguageCode.RU, "Литва"),
			new Translation(LanguageCode.SK, "Litva"),
			new Translation(LanguageCode.SL, "Litva"),
			new Translation(LanguageCode.SR, "Литванија"),
			new Translation(LanguageCode.SV, "Litauen"),
			new Translation(LanguageCode.TR, "Litvanya"),
			new Translation(LanguageCode.UK, "Литва"),
			new Translation(LanguageCode.UZ, "Litva"),
			new Translation(LanguageCode.ZH, "立陶宛"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.LT;
		public Alpha3Code Alpha3Code => Alpha3Code.LTU;
		public int NumericCode => 440;
		public string[] TLD => new [] { ".lt" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BY,
			Alpha2Code.LV,
			Alpha2Code.PL,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "370" };
	}
}
