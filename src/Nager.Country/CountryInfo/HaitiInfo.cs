namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Haiti
	/// </summary>
	public class HaitiInfo : ICountryInfo
	{
		public string CommonName => "Haiti";
		public string OfficialName => "Republic of Haiti";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "هايتي"),
			new Translation(LanguageCode.AZ, "Haiti"),
			new Translation(LanguageCode.BE, "Гаіці"),
			new Translation(LanguageCode.BG, "Хаити"),
			new Translation(LanguageCode.BS, "Haiti"),
			new Translation(LanguageCode.CA, "Haití"),
			new Translation(LanguageCode.CS, "Haiti"),
			new Translation(LanguageCode.DA, "Haiti"),
			new Translation(LanguageCode.DE, "Haiti"),
			new Translation(LanguageCode.EL, "Αϊτη"),
			new Translation(LanguageCode.EN, "Haiti"),
			new Translation(LanguageCode.ES, "Haití"),
			new Translation(LanguageCode.ET, "Haiti"),
			new Translation(LanguageCode.FA, "هائیتی"),
			new Translation(LanguageCode.FI, "Haiti"),
			new Translation(LanguageCode.FR, "Haïti"),
			new Translation(LanguageCode.HE, "האיטי"),
			new Translation(LanguageCode.HR, "Haiti"),
			new Translation(LanguageCode.HU, "Haiti"),
			new Translation(LanguageCode.HY, "Հայիթի"),
			new Translation(LanguageCode.ID, "Haiti"),
			new Translation(LanguageCode.IT, "Haiti"),
			new Translation(LanguageCode.JA, "ハイチ"),
			new Translation(LanguageCode.KA, "ჰაიტი"),
			new Translation(LanguageCode.KK, "Гаити"),
			new Translation(LanguageCode.KO, "아이티"),
			new Translation(LanguageCode.KY, "Гаити"),
			new Translation(LanguageCode.LT, "Haitis"),
			new Translation(LanguageCode.LV, "Haiti"),
			new Translation(LanguageCode.MK, "Хаити"),
			new Translation(LanguageCode.MN, "Гаити"),
			new Translation(LanguageCode.NB, "Haiti"),
			new Translation(LanguageCode.NL, "Haïti"),
			new Translation(LanguageCode.NN, "Haiti"),
			new Translation(LanguageCode.PL, "Haiti"),
			new Translation(LanguageCode.PT, "Haiti"),
			new Translation(LanguageCode.RO, "Haiti"),
			new Translation(LanguageCode.RU, "Гаити"),
			new Translation(LanguageCode.SK, "Haiti"),
			new Translation(LanguageCode.SL, "Haiti"),
			new Translation(LanguageCode.SR, "Хаити"),
			new Translation(LanguageCode.SV, "Haiti"),
			new Translation(LanguageCode.TR, "Haiti"),
			new Translation(LanguageCode.UK, "Гаїті"),
			new Translation(LanguageCode.UZ, "Gaiti"),
			new Translation(LanguageCode.ZH, "海地"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.HT;
		public Alpha3Code Alpha3Code => Alpha3Code.HTI;
		public int NumericCode => 332;
		public string[] TLD => new [] { ".ht" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DO,
		};

		public string[] Currencies => new [] { "HTG", "USD" };
		public string[] CallingCodes => new [] { "509" };
	}
}
