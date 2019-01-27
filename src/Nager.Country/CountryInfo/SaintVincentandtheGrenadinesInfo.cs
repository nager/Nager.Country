namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Vincent and the Grenadines
	/// </summary>
	public class SaintVincentAndTheGrenadinesInfo : ICountryInfo
	{
		public string CommonName => "Saint Vincent and the Grenadines";
		public string OfficialName => "Saint Vincent and the Grenadines";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "سانت فينسنت والغرينادين"),
			new Translation(LanguageCode.AZ, "Sent-Vinsent və Qrenadinlər"),
			new Translation(LanguageCode.BE, "Сент-Вінсент і Грэнадзіны"),
			new Translation(LanguageCode.BG, "Сейнт Винсънт и Гренадини"),
			new Translation(LanguageCode.BS, "Sveti Vinsent i Grenadin"),
			new Translation(LanguageCode.CA, "Saint Vincent i les Grenadines"),
			new Translation(LanguageCode.CS, "Svatý Vincenc a Grenadiny"),
			new Translation(LanguageCode.DA, "Saint Vincent og Grenadinerne"),
			new Translation(LanguageCode.DE, "St. Vincent und die Grenadinen"),
			new Translation(LanguageCode.EL, "Άγιος Βικέντιος και Γρεναδίνες"),
			new Translation(LanguageCode.EN, "Saint Vincent and the Grenadines"),
			new Translation(LanguageCode.ES, "San Vicente y las Granadinas"),
			new Translation(LanguageCode.ET, "Saint Vincent ja Grenadiinid"),
			new Translation(LanguageCode.FA, "سنت وینسنت و گرنادین"),
			new Translation(LanguageCode.FI, "Saint Vincent ja Grenadiinit"),
			new Translation(LanguageCode.FR, "Saint-Vincent et les Grenadines"),
			new Translation(LanguageCode.HE, "סנט וינסנט והגרנדינים"),
			new Translation(LanguageCode.HR, "Sveti Vincent i Grenadini"),
			new Translation(LanguageCode.HU, "Saint Vincent és a Grenadine-szigetek"),
			new Translation(LanguageCode.HY, "Սենթ Վինսենթ և Գրենադիններ"),
			new Translation(LanguageCode.ID, "Saint Vincent dan the Grenadines"),
			new Translation(LanguageCode.IT, "Saint Vincent e Grenadine"),
			new Translation(LanguageCode.JA, "セントビンセントおよびグレナディーン諸島"),
			new Translation(LanguageCode.KA, "სენტ-ვინსენტი და გრენადინები"),
			new Translation(LanguageCode.KK, "Сент-Винсент және Гренадин аралдары"),
			new Translation(LanguageCode.KO, "세인트 빈센트 그레나딘"),
			new Translation(LanguageCode.KY, "Сент-Винсент жана Гренадиналар"),
			new Translation(LanguageCode.LT, "Šventasis Vincentas ir Grenadinai"),
			new Translation(LanguageCode.LV, "Sentvinsenta un Grenadīnas"),
			new Translation(LanguageCode.MK, "Свети Винсент и Гренадините"),
			new Translation(LanguageCode.MN, "Сэнт Винсэнт ба Гренадин"),
			new Translation(LanguageCode.NB, "Saint Vincent og Grenadinene"),
			new Translation(LanguageCode.NL, "Saint Vincent en de Grenadines"),
			new Translation(LanguageCode.NN, "Saint Vincent og Grenadinane"),
			new Translation(LanguageCode.PL, "Saint Vincent i Grenadyny"),
			new Translation(LanguageCode.PT, "São Vicente e Granadinas"),
			new Translation(LanguageCode.RO, "Saint Vincent și Grenadinele"),
			new Translation(LanguageCode.RU, "Сент-Винсент и Гренадины"),
			new Translation(LanguageCode.SK, "Svätý Vincent a Grenadíny"),
			new Translation(LanguageCode.SL, "Saint Vincent in Grenadine"),
			new Translation(LanguageCode.SR, "Сент Винсент и Гренадини"),
			new Translation(LanguageCode.SV, "Saint Vincent och Grenadinerna"),
			new Translation(LanguageCode.TR, "Saint Vincent ve Grenadinler"),
			new Translation(LanguageCode.UK, "Сент-Вінсент і Гренадини"),
			new Translation(LanguageCode.UZ, "Sent-Vinsent va Grenadin"),
			new Translation(LanguageCode.ZH, "圣文森及格瑞那丁"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.VC;
		public Alpha3Code Alpha3Code => Alpha3Code.VCT;
		public int NumericCode => 670;
		public string[] TLD => new [] { ".vc" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1784" };
	}
}
