namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Puerto Rico
	/// </summary>
	public class PuertoRicoInfo : ICountryInfo
	{
		public string CommonName => "Puerto Rico";
		public string OfficialName => "Commonwealth of Puerto Rico";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "بورتوريكو"),
			new Translation(LanguageCode.AZ, "Puerto Riko"),
			new Translation(LanguageCode.BE, "Пуэрта-Рыка"),
			new Translation(LanguageCode.BG, "Пуерто Рико"),
			new Translation(LanguageCode.BS, "Porto Riko"),
			new Translation(LanguageCode.CA, "Puerto Rico"),
			new Translation(LanguageCode.CS, "Portoriko"),
			new Translation(LanguageCode.DA, "Puerto Rico"),
			new Translation(LanguageCode.DE, "Puerto Rico"),
			new Translation(LanguageCode.EL, "Πουέρτο Ρίκο"),
			new Translation(LanguageCode.EN, "Puerto Rico"),
			new Translation(LanguageCode.ES, "Puerto Rico"),
			new Translation(LanguageCode.ET, "Puerto Rico"),
			new Translation(LanguageCode.FA, "پورتوریکو"),
			new Translation(LanguageCode.FI, "Puerto Rico"),
			new Translation(LanguageCode.FR, "Porto Rico"),
			new Translation(LanguageCode.HE, "פוארטו ריקו"),
			new Translation(LanguageCode.HR, "Portoriko"),
			new Translation(LanguageCode.HU, "Puerto Rico"),
			new Translation(LanguageCode.HY, "Պուերտո Ռիկո"),
			new Translation(LanguageCode.ID, "Puerto Riko"),
			new Translation(LanguageCode.IT, "Porto Rico"),
			new Translation(LanguageCode.JA, "プエルトリコ"),
			new Translation(LanguageCode.KA, "პუერტო-რიკო"),
			new Translation(LanguageCode.KK, "Пуэрто-Рико"),
			new Translation(LanguageCode.KO, "푸에르토 리코"),
			new Translation(LanguageCode.KY, "Пуэрто-Рико"),
			new Translation(LanguageCode.LT, "Puerto Rikas"),
			new Translation(LanguageCode.LV, "Puertoriko"),
			new Translation(LanguageCode.MK, "Порторико"),
			new Translation(LanguageCode.MN, "Пуэрто Рико"),
			new Translation(LanguageCode.NB, "Puerto Rico"),
			new Translation(LanguageCode.NL, "Puerto Rico"),
			new Translation(LanguageCode.NN, "Puerto Rico"),
			new Translation(LanguageCode.PL, "Portoryko"),
			new Translation(LanguageCode.PT, "Porto Rico"),
			new Translation(LanguageCode.RO, "Puerto Rico"),
			new Translation(LanguageCode.RU, "Пуэрто-Рико"),
			new Translation(LanguageCode.SK, "Portoriko"),
			new Translation(LanguageCode.SL, "Portoriko"),
			new Translation(LanguageCode.SR, "Порторико"),
			new Translation(LanguageCode.SV, "Puerto Rico"),
			new Translation(LanguageCode.TR, "Porto Riko"),
			new Translation(LanguageCode.UK, "Пуерто-Ріко"),
			new Translation(LanguageCode.UZ, "Puerto-Riko"),
			new Translation(LanguageCode.ZH, "波多黎各"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.PR;
		public Alpha3Code Alpha3Code => Alpha3Code.PRI;
		public int NumericCode => 630;
		public string[] TLD => new [] { ".pr" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1787", "1939" };
	}
}
