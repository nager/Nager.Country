namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Nicaragua
	/// </summary>
	public class NicaraguaInfo : ICountryInfo
	{
		public string CommonName => "Nicaragua";
		public string OfficialName => "Republic of Nicaragua";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "نيكاراغوا"),
			new Translation(LanguageCode.AZ, "Nikaraqua"),
			new Translation(LanguageCode.BE, "Нікарагуа"),
			new Translation(LanguageCode.BG, "Никарагуа"),
			new Translation(LanguageCode.BS, "Nikaragva"),
			new Translation(LanguageCode.CA, "Nicaragua"),
			new Translation(LanguageCode.CS, "Nikaragua"),
			new Translation(LanguageCode.DA, "Nicaragua"),
			new Translation(LanguageCode.DE, "Nicaragua"),
			new Translation(LanguageCode.EL, "Νικαράγουα"),
			new Translation(LanguageCode.EN, "Nicaragua"),
			new Translation(LanguageCode.ES, "Nicaragua"),
			new Translation(LanguageCode.ET, "Nicaragua"),
			new Translation(LanguageCode.FA, "نیکاراگوئه"),
			new Translation(LanguageCode.FI, "Nicaragua"),
			new Translation(LanguageCode.FR, "Nicaragua"),
			new Translation(LanguageCode.HE, "ניקרגואה"),
			new Translation(LanguageCode.HR, "Nikaragva"),
			new Translation(LanguageCode.HU, "Nicaragua"),
			new Translation(LanguageCode.HY, "Նիկարագուա"),
			new Translation(LanguageCode.ID, "Nikaragua"),
			new Translation(LanguageCode.IT, "Nicaragua"),
			new Translation(LanguageCode.JA, "ニカラグア"),
			new Translation(LanguageCode.KA, "ნიკარაგუა"),
			new Translation(LanguageCode.KK, "Никарагуа"),
			new Translation(LanguageCode.KO, "니카라과"),
			new Translation(LanguageCode.KY, "Никарагуа"),
			new Translation(LanguageCode.LT, "Nikaragva"),
			new Translation(LanguageCode.LV, "Nikaragva"),
			new Translation(LanguageCode.MK, "Никарагва"),
			new Translation(LanguageCode.MN, "Никарагуа"),
			new Translation(LanguageCode.NB, "Nicaragua"),
			new Translation(LanguageCode.NL, "Nicaragua"),
			new Translation(LanguageCode.NN, "Nicaragua"),
			new Translation(LanguageCode.PL, "Nikaragua"),
			new Translation(LanguageCode.PT, "Nicarágua"),
			new Translation(LanguageCode.RO, "Nicaragua"),
			new Translation(LanguageCode.RU, "Никарагуа"),
			new Translation(LanguageCode.SK, "Nikaragua"),
			new Translation(LanguageCode.SL, "Nikaragva"),
			new Translation(LanguageCode.SR, "Никарагва"),
			new Translation(LanguageCode.SV, "Nicaragua"),
			new Translation(LanguageCode.TR, "Nikaragua"),
			new Translation(LanguageCode.UK, "Нікарагуа"),
			new Translation(LanguageCode.UZ, "Nikaragua"),
			new Translation(LanguageCode.ZH, "尼加拉瓜"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.NI;
		public Alpha3Code Alpha3Code => Alpha3Code.NIC;
		public int NumericCode => 558;
		public string[] TLD => new [] { ".ni" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CR,
			Alpha2Code.HN,
		};

		public string[] Currencies => new [] { "NIO" };
		public string[] CallingCodes => new [] { "505" };
	}
}
