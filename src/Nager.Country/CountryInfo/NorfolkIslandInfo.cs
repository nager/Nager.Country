namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Norfolk Island
	/// </summary>
	public class NorfolkIslandInfo : ICountryInfo
	{
		public string CommonName => "Norfolk Island";
		public string OfficialName => "Territory of Norfolk Island";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جزيرة نورفولك"),
			new Translation(LanguageCode.AZ, "Norfolk adası"),
			new Translation(LanguageCode.BE, "Востраў Норфалк"),
			new Translation(LanguageCode.BG, "остров Норфолк"),
			new Translation(LanguageCode.BS, "Ostrvo Norfolk"),
			new Translation(LanguageCode.CA, "Norfolk, illa"),
			new Translation(LanguageCode.CS, "Norfolk"),
			new Translation(LanguageCode.DA, "Norfolk Island"),
			new Translation(LanguageCode.DE, "Norfolkinsel"),
			new Translation(LanguageCode.EL, "Νησί Νόρφολκ"),
			new Translation(LanguageCode.EN, "Norfolk Island"),
			new Translation(LanguageCode.ES, "Isla Norfolk"),
			new Translation(LanguageCode.ET, "Norfolk"),
			new Translation(LanguageCode.FA, "جزیرهٔ نورفولک"),
			new Translation(LanguageCode.FI, "Norfolkinsaari"),
			new Translation(LanguageCode.FR, "Île Norfolk"),
			new Translation(LanguageCode.HE, "איי נורפוק"),
			new Translation(LanguageCode.HR, "Otok Norfolk"),
			new Translation(LanguageCode.HU, "Norfolk-sziget"),
			new Translation(LanguageCode.HY, "Նորֆոլկ կղզի"),
			new Translation(LanguageCode.ID, "Kepulauan Norfolk"),
			new Translation(LanguageCode.IT, "Isola Norfolk"),
			new Translation(LanguageCode.JA, "ノーフォーク島"),
			new Translation(LanguageCode.KA, "ნორფოლკის კუნძული"),
			new Translation(LanguageCode.KK, "Норфолк аралы"),
			new Translation(LanguageCode.KO, "노퍽 섬"),
			new Translation(LanguageCode.KY, "Норфолк аралы"),
			new Translation(LanguageCode.LT, "Norfolko sala"),
			new Translation(LanguageCode.LV, "Norfolkas sala"),
			new Translation(LanguageCode.MK, "Норфолшки Остров"),
			new Translation(LanguageCode.MN, "Норфолк арлууд"),
			new Translation(LanguageCode.NB, "Norfolk Island"),
			new Translation(LanguageCode.NL, "Norfolk"),
			new Translation(LanguageCode.NN, "Norfolk Island"),
			new Translation(LanguageCode.PL, "Norfolk"),
			new Translation(LanguageCode.PT, "Ilha Norfolk"),
			new Translation(LanguageCode.RO, "Insula Norfolk"),
			new Translation(LanguageCode.RU, "Остров Норфолк"),
			new Translation(LanguageCode.SK, "Norfolk"),
			new Translation(LanguageCode.SL, "Norfolški otok"),
			new Translation(LanguageCode.SR, "Острво Норфок"),
			new Translation(LanguageCode.SV, "Norfolkön"),
			new Translation(LanguageCode.TR, "Norfolk Adası"),
			new Translation(LanguageCode.UK, "Острів Норфолк"),
			new Translation(LanguageCode.UZ, "Norfolk oroli"),
			new Translation(LanguageCode.ZH, "诺福克岛"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.NF;
		public Alpha3Code Alpha3Code => Alpha3Code.NFK;
		public int NumericCode => 574;
		public string[] TLD => new [] { ".nf" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "672" };
	}
}
