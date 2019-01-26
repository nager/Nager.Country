namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Canada
	/// </summary>
	public class CanadaInfo : ICountryInfo
	{
		public string CommonName => "Canada";
		public string OfficialName => "Canada";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "كندا"),
			new Translation(LanguageCode.AZ, "Kanada"),
			new Translation(LanguageCode.BE, "Канада"),
			new Translation(LanguageCode.BG, "Канада"),
			new Translation(LanguageCode.BS, "Kanada"),
			new Translation(LanguageCode.CA, "Canadà"),
			new Translation(LanguageCode.CS, "Kanada"),
			new Translation(LanguageCode.DA, "Canada"),
			new Translation(LanguageCode.DE, "Kanada"),
			new Translation(LanguageCode.EL, "Καναδάς"),
			new Translation(LanguageCode.EN, "Canada"),
			new Translation(LanguageCode.ES, "Canadá"),
			new Translation(LanguageCode.ET, "Kanada"),
			new Translation(LanguageCode.FA, "کانادا"),
			new Translation(LanguageCode.FI, "Kanada"),
			new Translation(LanguageCode.FR, "Canada"),
			new Translation(LanguageCode.HE, "קנדה"),
			new Translation(LanguageCode.HR, "Kanada"),
			new Translation(LanguageCode.HU, "Kanada"),
			new Translation(LanguageCode.HY, "Կանադա"),
			new Translation(LanguageCode.ID, "Kanada"),
			new Translation(LanguageCode.IT, "Canada"),
			new Translation(LanguageCode.JA, "カナダ"),
			new Translation(LanguageCode.KA, "კანადა"),
			new Translation(LanguageCode.KK, "Канада"),
			new Translation(LanguageCode.KO, "캐나다"),
			new Translation(LanguageCode.KY, "Канада"),
			new Translation(LanguageCode.LT, "Kanada"),
			new Translation(LanguageCode.LV, "Kanāda"),
			new Translation(LanguageCode.MK, "Канада"),
			new Translation(LanguageCode.MN, "Канад"),
			new Translation(LanguageCode.NB, "Canada"),
			new Translation(LanguageCode.NL, "Canada"),
			new Translation(LanguageCode.NN, "Canada"),
			new Translation(LanguageCode.PL, "Kanada"),
			new Translation(LanguageCode.PT, "Canadá"),
			new Translation(LanguageCode.RO, "Canada"),
			new Translation(LanguageCode.RU, "Канада"),
			new Translation(LanguageCode.SK, "Kanada"),
			new Translation(LanguageCode.SL, "Kanada"),
			new Translation(LanguageCode.SR, "Канада"),
			new Translation(LanguageCode.SV, "Kanada"),
			new Translation(LanguageCode.TR, "Kanada"),
			new Translation(LanguageCode.UK, "Канада"),
			new Translation(LanguageCode.UZ, "Kanada"),
			new Translation(LanguageCode.ZH, "加拿大"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.CA;
		public Alpha3Code Alpha3Code => Alpha3Code.CAN;
		public int NumericCode => 124;
		public string[] TLD => new [] { ".ca" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.US,
		};

		public string[] Currencies => new [] { "CAD" };
		public string[] CallingCodes => new [] { "1" };
	}
}
