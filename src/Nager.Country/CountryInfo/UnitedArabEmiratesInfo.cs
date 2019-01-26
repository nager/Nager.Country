namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United Arab Emirates
	/// </summary>
	public class UnitedArabEmiratesInfo : ICountryInfo
	{
		public string CommonName => "United Arab Emirates";
		public string OfficialName => "United Arab Emirates";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "الإمارات العربية المتحدة"),
			new Translation(LanguageCode.AZ, "Birləşmiş Ərəb Əmirlikləri"),
			new Translation(LanguageCode.BE, "Аб’яднаныя Арабскія Эміраты"),
			new Translation(LanguageCode.BG, "Обединени арабски емирства"),
			new Translation(LanguageCode.BS, "Ujedinjeni Arapski Emirati"),
			new Translation(LanguageCode.CA, "Emirats Àrabs Units"),
			new Translation(LanguageCode.CS, "Spojené arabské emiráty"),
			new Translation(LanguageCode.DA, "Forenede Arabiske Emirater"),
			new Translation(LanguageCode.DE, "Vereinigte Arabische Emirate"),
			new Translation(LanguageCode.EL, "Ηνωμένα Αραβικά Εμιράτα"),
			new Translation(LanguageCode.EN, "United Arab Emirates"),
			new Translation(LanguageCode.ES, "Emiratos Árabes Unidos"),
			new Translation(LanguageCode.ET, "Araabia Ühendemiraadid"),
			new Translation(LanguageCode.FA, "امارات متحدهٔ عربی"),
			new Translation(LanguageCode.FI, "Arabiemiirikunnat"),
			new Translation(LanguageCode.FR, "Émirats Arabes Unis"),
			new Translation(LanguageCode.HE, "איחוד האמירויות הערביות"),
			new Translation(LanguageCode.HR, "Ujedinjeni Arapski Emirati"),
			new Translation(LanguageCode.HU, "Egyesült Arab Emírségek"),
			new Translation(LanguageCode.HY, "Արաբական Միացյալ Էմիրություններ"),
			new Translation(LanguageCode.ID, "Uni Emirat Arab"),
			new Translation(LanguageCode.IT, "Emirati Arabi Uniti"),
			new Translation(LanguageCode.JA, "アラブ首長国連邦"),
			new Translation(LanguageCode.KA, "არაბთა გაერთიანებული საამიროები"),
			new Translation(LanguageCode.KK, "Біріккен Араб Әмірліктері"),
			new Translation(LanguageCode.KO, "아랍 에미리트"),
			new Translation(LanguageCode.KY, "Бириккен Араб Эмираттары"),
			new Translation(LanguageCode.LT, "Jungtiniai Arabų Emyratai"),
			new Translation(LanguageCode.LV, "Apvienotie Arābu Emirāti"),
			new Translation(LanguageCode.MK, "Обединети Арапски Емирати"),
			new Translation(LanguageCode.MN, "Арабын Нэгдсэн Эмират"),
			new Translation(LanguageCode.NB, "De forente arabiske emirater"),
			new Translation(LanguageCode.NL, "Verenigde Arabische Emiraten"),
			new Translation(LanguageCode.NN, "Dei sameinte arabiske emirata"),
			new Translation(LanguageCode.PL, "Zjednoczone Emiraty Arabskie"),
			new Translation(LanguageCode.PT, "Emirados Árabes Unidos"),
			new Translation(LanguageCode.RO, "Emiratele Arabe Unite"),
			new Translation(LanguageCode.RU, "ОАЭ"),
			new Translation(LanguageCode.SK, "Spojené arabské emiráty"),
			new Translation(LanguageCode.SL, "Združeni arabski emirati"),
			new Translation(LanguageCode.SR, "Уједињени Арапски Емирати"),
			new Translation(LanguageCode.SV, "Förenade Arabemiraten"),
			new Translation(LanguageCode.TR, "Birleşik Arap Emirlikleri"),
			new Translation(LanguageCode.UK, "Об'єднані Арабські Емірати"),
			new Translation(LanguageCode.UZ, "Birlashgan Arab Amirliklari"),
			new Translation(LanguageCode.ZH, "阿联酋"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.AE;
		public Alpha3Code Alpha3Code => Alpha3Code.ARE;
		public int NumericCode => 784;
		public string[] TLD => new [] { ".ae", "امارات." };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.OM,
			Alpha2Code.SA,
		};

		public string[] Currencies => new [] { "AED" };
		public string[] CallingCodes => new [] { "971" };
	}
}
