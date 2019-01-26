namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Antarctica
	/// </summary>
	public class AntarcticaInfo : ICountryInfo
	{
		public string CommonName => "Antarctica";
		public string OfficialName => "Antarctica";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "القارة القطبية الجنوبية"),
			new Translation(LanguageCode.AZ, "Antarktika"),
			new Translation(LanguageCode.BE, "Антарктыка"),
			new Translation(LanguageCode.BG, "Антарктика"),
			new Translation(LanguageCode.BS, "Antarktika"),
			new Translation(LanguageCode.CA, "Antàrtida"),
			new Translation(LanguageCode.CS, "Antarktida"),
			new Translation(LanguageCode.DA, "Antarktis"),
			new Translation(LanguageCode.DE, "Antarktika"),
			new Translation(LanguageCode.EL, "Ανταρκτική"),
			new Translation(LanguageCode.EN, "Antarctica"),
			new Translation(LanguageCode.ES, "Antártida"),
			new Translation(LanguageCode.ET, "Antarktis"),
			new Translation(LanguageCode.FA, "جنوبگان"),
			new Translation(LanguageCode.FI, "Antarktis"),
			new Translation(LanguageCode.FR, "Antarctique"),
			new Translation(LanguageCode.HE, "אנטארקטיקה"),
			new Translation(LanguageCode.HR, "Antarktika"),
			new Translation(LanguageCode.HU, "Antarktisz"),
			new Translation(LanguageCode.HY, "Անտարկտիդա"),
			new Translation(LanguageCode.ID, "Antarctica"),
			new Translation(LanguageCode.IT, "Antartide"),
			new Translation(LanguageCode.JA, "南極"),
			new Translation(LanguageCode.KA, "ანტარქტიკა"),
			new Translation(LanguageCode.KK, "Антарктида"),
			new Translation(LanguageCode.KO, "남극 대륙"),
			new Translation(LanguageCode.KY, "Антарктика"),
			new Translation(LanguageCode.LT, "Antarktida"),
			new Translation(LanguageCode.LV, "Antarktika"),
			new Translation(LanguageCode.MK, "Антарктик"),
			new Translation(LanguageCode.MN, "Антарктик"),
			new Translation(LanguageCode.NB, "Antarktis"),
			new Translation(LanguageCode.NL, "Antarctica"),
			new Translation(LanguageCode.NN, "Antarktis"),
			new Translation(LanguageCode.PL, "Antarktyka"),
			new Translation(LanguageCode.PT, "Antártida"),
			new Translation(LanguageCode.RO, "Antarctica"),
			new Translation(LanguageCode.RU, "Антарктида"),
			new Translation(LanguageCode.SK, "Antarktída"),
			new Translation(LanguageCode.SL, "Antarktika"),
			new Translation(LanguageCode.SR, "Антарктик"),
			new Translation(LanguageCode.SV, "Antarktis"),
			new Translation(LanguageCode.TR, "Antarktika"),
			new Translation(LanguageCode.UK, "Антарктида"),
			new Translation(LanguageCode.UZ, "Antarktida"),
			new Translation(LanguageCode.ZH, "南极洲"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.AQ;
		public Alpha3Code Alpha3Code => Alpha3Code.ATA;
		public int NumericCode => 010;
		public string[] TLD => new [] { ".aq" };

		public Region Region => Region.None;
		public SubRegion SubRegion => SubRegion.None;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "" };
		public string[] CallingCodes => new string[0];
	}
}
