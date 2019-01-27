namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Svalbard and Jan Mayen
	/// </summary>
	public class SvalbardAndJanMayenInfo : ICountryInfo
	{
		public string CommonName => "Svalbard and Jan Mayen";
		public string OfficialName => "Svalbard og Jan Mayen";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "سفالبارد ويان ماين"),
			new Translation(LanguageCode.AZ, "Svalbard və Yan-Mayen"),
			new Translation(LanguageCode.BE, "Шпіцберген і Ян-Маен"),
			new Translation(LanguageCode.BG, "Свалбард и Ян Майен"),
			new Translation(LanguageCode.BS, "Svalbard i Jan Majen"),
			new Translation(LanguageCode.CA, "Svalbard i Jan Mayen"),
			new Translation(LanguageCode.CS, "Špicberky a Jan Mayen"),
			new Translation(LanguageCode.DA, "Norge Svalbard og Jan Mayen"),
			new Translation(LanguageCode.DE, "Svalbard und Jan Mayen"),
			new Translation(LanguageCode.EL, "Σβάλμπαρντ και Γιαν Μαγιέν"),
			new Translation(LanguageCode.EN, "Svalbard and Jan Mayen"),
			new Translation(LanguageCode.ES, "Svalbard y Jan Mayen"),
			new Translation(LanguageCode.ET, "Svalbard ja Jan Mayen"),
			new Translation(LanguageCode.FA, "اسوالبارد و جان‌ماین"),
			new Translation(LanguageCode.FI, "Svalbard ja Jan Mayen"),
			new Translation(LanguageCode.FR, "Svalbard et Île Jan Mayen"),
			new Translation(LanguageCode.HE, "סוולבארד ויאן מאיין"),
			new Translation(LanguageCode.HR, "Svalbard i Jan Mayen"),
			new Translation(LanguageCode.HU, "Spitzbergák és Jan Mayen"),
			new Translation(LanguageCode.HY, "Սվալբարդ և Յան Մայեն"),
			new Translation(LanguageCode.ID, "Svalbard dan Jan Mayen"),
			new Translation(LanguageCode.IT, "Svalbard e Jan Mayen"),
			new Translation(LanguageCode.JA, "スヴァールバル諸島およびヤンマイエン島"),
			new Translation(LanguageCode.KA, "შპიცბერგენი და იან-მაიენი"),
			new Translation(LanguageCode.KK, "Шпицберген және Ян-Майен"),
			new Translation(LanguageCode.KO, "스발 바르와 얀 메이 엔"),
			new Translation(LanguageCode.KY, "Свалбард жана Жан Майен"),
			new Translation(LanguageCode.LT, "Svalbardas ir Janas Majenas"),
			new Translation(LanguageCode.LV, "Svalbāra un Jana Majena sala"),
			new Translation(LanguageCode.MK, "Свалбард и Жан Мејен"),
			new Translation(LanguageCode.MN, "Свалбард ба Ян Майен"),
			new Translation(LanguageCode.NB, "Svalbard og Jan Mayen"),
			new Translation(LanguageCode.NL, "Spitsbergen en Jan Mayen"),
			new Translation(LanguageCode.NN, "Svalbard og Jan Mayen"),
			new Translation(LanguageCode.PL, "Svalbard i Jan Mayen"),
			new Translation(LanguageCode.PT, "Svalbard e Jan Mayen"),
			new Translation(LanguageCode.RO, "Svalbard și Jan Mayen"),
			new Translation(LanguageCode.RU, "Шпицберген и Ян-Майен"),
			new Translation(LanguageCode.SK, "Svalbard a Jan Mayen"),
			new Translation(LanguageCode.SL, "Svalbard in Jan Mayen"),
			new Translation(LanguageCode.SR, "Свалбард и Јан Мајен"),
			new Translation(LanguageCode.SV, "Svalbard och Jan Mayen"),
			new Translation(LanguageCode.TR, "Svalbard ve Jan Mayen Adaları"),
			new Translation(LanguageCode.UK, "Свальбард і Ян-Маєн"),
			new Translation(LanguageCode.UZ, "Svalbard va Yan-Mayen"),
			new Translation(LanguageCode.ZH, "斯瓦尔巴群岛和扬马延岛"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.SJ;
		public Alpha3Code Alpha3Code => Alpha3Code.SJM;
		public int NumericCode => 744;
		public string[] TLD => new [] { ".sj" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NOK" };
		public string[] CallingCodes => new [] { "4779" };
	}
}
