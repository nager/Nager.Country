namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Micronesia
	/// </summary>
	public class MicronesiaInfo : ICountryInfo
	{
		public string CommonName => "Micronesia";
		public string OfficialName => "Federated States of Micronesia";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "ولايات ميكرونيسيا المتحدة"),
			new Translation(LanguageCode.AZ, "Mikroneziya"),
			new Translation(LanguageCode.BE, "Мікранезія"),
			new Translation(LanguageCode.BG, "Микронезия"),
			new Translation(LanguageCode.BS, "Mikronezija"),
			new Translation(LanguageCode.CA, "Micronèsia, Estats Federats de"),
			new Translation(LanguageCode.CS, "Mikronésie"),
			new Translation(LanguageCode.DA, "Mikronesien"),
			new Translation(LanguageCode.DE, "Mikronesien"),
			new Translation(LanguageCode.EL, "Ομόσπονδες Πολιτείες της Μικρονησίας"),
			new Translation(LanguageCode.EN, "Micronesia, Federated States of"),
			new Translation(LanguageCode.ES, "Micronesia"),
			new Translation(LanguageCode.ET, "Mikroneesia Liiduriigid"),
			new Translation(LanguageCode.FA, "میکرونزی"),
			new Translation(LanguageCode.FI, "Mikronesian liittovaltio"),
			new Translation(LanguageCode.FR, "Micronésie"),
			new Translation(LanguageCode.HE, "מיקרונזיה"),
			new Translation(LanguageCode.HR, "Mikronezija"),
			new Translation(LanguageCode.HU, "Mikronéziai Szövetségi Államok"),
			new Translation(LanguageCode.HY, "Միկրոնեզիա"),
			new Translation(LanguageCode.ID, "Federasi Mikronesia"),
			new Translation(LanguageCode.IT, "Stati Federati di Micronesia"),
			new Translation(LanguageCode.JA, "ミクロネシア連邦"),
			new Translation(LanguageCode.KA, "მიკრონეზია"),
			new Translation(LanguageCode.KK, "Микронезия"),
			new Translation(LanguageCode.KO, "미크로네시아,"),
			new Translation(LanguageCode.KY, "Микронезия"),
			new Translation(LanguageCode.LT, "Mikronezija"),
			new Translation(LanguageCode.LV, "Mikronēzija"),
			new Translation(LanguageCode.MK, "Микронезија"),
			new Translation(LanguageCode.MN, "Микронези"),
			new Translation(LanguageCode.NB, "Mikronesiaføderasjonen"),
			new Translation(LanguageCode.NL, "Micronesië, Federale Staten"),
			new Translation(LanguageCode.NN, "Mikronesiaføderasjonen"),
			new Translation(LanguageCode.PL, "Mikronezja"),
			new Translation(LanguageCode.PT, "Micronésia"),
			new Translation(LanguageCode.RO, "Micronezia"),
			new Translation(LanguageCode.RU, "Микронезия"),
			new Translation(LanguageCode.SK, "Mikronézia"),
			new Translation(LanguageCode.SL, "Mikronezija"),
			new Translation(LanguageCode.SR, "Микронезија"),
			new Translation(LanguageCode.SV, "Mikronesiska federationen"),
			new Translation(LanguageCode.TR, "Mikronezya"),
			new Translation(LanguageCode.UK, "Мікронезія"),
			new Translation(LanguageCode.UZ, "Mikroneziya"),
			new Translation(LanguageCode.ZH, "密克罗尼西亚联邦"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.FM;
		public Alpha3Code Alpha3Code => Alpha3Code.FSM;
		public int NumericCode => 583;
		public string[] TLD => new [] { ".fm" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "691" };
	}
}
