namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Macau
	/// </summary>
	public class MacauInfo : ICountryInfo
	{
		public string CommonName => "Macau";
		public string OfficialName => "Macao Special Administrative Region of the People's Republic of China";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "ماكاو"),
			new Translation(LanguageCode.AZ, "Makao"),
			new Translation(LanguageCode.BE, "Макаа, САР (Кітай)"),
			new Translation(LanguageCode.BG, "Макао, САР на Китай"),
			new Translation(LanguageCode.BS, "Makao (SAR Kina)"),
			new Translation(LanguageCode.CA, "Macau"),
			new Translation(LanguageCode.CS, "Macao"),
			new Translation(LanguageCode.DA, "Macao"),
			new Translation(LanguageCode.DE, "Macao"),
			new Translation(LanguageCode.EL, "Μακάου"),
			new Translation(LanguageCode.EN, "Macao"),
			new Translation(LanguageCode.ES, "Macao"),
			new Translation(LanguageCode.ET, "Aomen - Hiina erihalduspiirkond"),
			new Translation(LanguageCode.FA, "ماکائو"),
			new Translation(LanguageCode.FI, "Macao"),
			new Translation(LanguageCode.FR, "Macao"),
			new Translation(LanguageCode.HE, "מקאו (מחוז מנהלי מיוחד של סין)"),
			new Translation(LanguageCode.HR, "PUP Makao Kina"),
			new Translation(LanguageCode.HU, "Makao"),
			new Translation(LanguageCode.HY, "Չինաստանի Մակաո ՀՎՇ"),
			new Translation(LanguageCode.ID, "Makau"),
			new Translation(LanguageCode.IT, "Macao"),
			new Translation(LanguageCode.JA, "マカオ"),
			new Translation(LanguageCode.KA, "მაკაო"),
			new Translation(LanguageCode.KK, "Макао"),
			new Translation(LanguageCode.KO, "마카오"),
			new Translation(LanguageCode.KY, "Макау Кытай ААА"),
			new Translation(LanguageCode.LT, "Makao"),
			new Translation(LanguageCode.LV, "Ķīnas īpašās pārvaldes apgabals Makao"),
			new Translation(LanguageCode.MK, "Макао САР"),
			new Translation(LanguageCode.MN, "Макао"),
			new Translation(LanguageCode.NB, "Macao"),
			new Translation(LanguageCode.NL, "Macao"),
			new Translation(LanguageCode.NN, "Macao"),
			new Translation(LanguageCode.PL, "Makau"),
			new Translation(LanguageCode.PT, "Macau, RAE da China"),
			new Translation(LanguageCode.RO, "R.A.S. Macao a Chinei"),
			new Translation(LanguageCode.RU, "Макао"),
			new Translation(LanguageCode.SK, "Macao – OAO Číny"),
			new Translation(LanguageCode.SL, "Macao"),
			new Translation(LanguageCode.SR, "САР Макао (Кина)"),
			new Translation(LanguageCode.SV, "Macau"),
			new Translation(LanguageCode.TR, "Çin Makao ÖYB"),
			new Translation(LanguageCode.UK, "Аоминь"),
			new Translation(LanguageCode.UZ, "Makao (Xitoy MMH)"),
			new Translation(LanguageCode.ZH, "澳门"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.MO;
		public Alpha3Code Alpha3Code => Alpha3Code.MAC;
		public int NumericCode => 446;
		public string[] TLD => new [] { ".mo" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
		};

		public string[] Currencies => new [] { "MOP" };
		public string[] CallingCodes => new [] { "853" };
	}
}
