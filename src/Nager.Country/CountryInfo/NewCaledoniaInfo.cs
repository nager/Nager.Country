namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// New Caledonia
	/// </summary>
	public class NewCaledoniaInfo : ICountryInfo
	{
		public string CommonName => "New Caledonia";
		public string OfficialName => "New Caledonia";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "كاليدونيا الجديدة"),
			new Translation(LanguageCode.AZ, "Yeni Kaledoniya"),
			new Translation(LanguageCode.BE, "Новая Каледонія"),
			new Translation(LanguageCode.BG, "Нова Каледония"),
			new Translation(LanguageCode.BS, "Nova Kaledonija"),
			new Translation(LanguageCode.CA, "Nova Caledònia"),
			new Translation(LanguageCode.CS, "Nová Kaledonie"),
			new Translation(LanguageCode.DA, "Ny Kaledonien"),
			new Translation(LanguageCode.DE, "Neukaledonien"),
			new Translation(LanguageCode.EL, "Νέα Καληδονία"),
			new Translation(LanguageCode.EN, "New Caledonia"),
			new Translation(LanguageCode.ES, "Nueva Caledonia"),
			new Translation(LanguageCode.ET, "Uus-Kaledoonia"),
			new Translation(LanguageCode.FA, "کالدونیای جدید"),
			new Translation(LanguageCode.FI, "Uusi-Kaledonia"),
			new Translation(LanguageCode.FR, "Nouvelle-Calédonie"),
			new Translation(LanguageCode.HE, "קלדוניה החדשה"),
			new Translation(LanguageCode.HR, "Nova Kaledonija"),
			new Translation(LanguageCode.HU, "Új-Kaledónia"),
			new Translation(LanguageCode.HY, "Նոր Կալեդոնիա"),
			new Translation(LanguageCode.ID, "Kaledonia Baru"),
			new Translation(LanguageCode.IT, "Nuova Caledonia"),
			new Translation(LanguageCode.JA, "ニューカレドニア"),
			new Translation(LanguageCode.KA, "ახალი კალედონია"),
			new Translation(LanguageCode.KK, "Жаңа Каледония"),
			new Translation(LanguageCode.KO, "뉴 칼레도니아"),
			new Translation(LanguageCode.KY, "Жаӊы Каледония"),
			new Translation(LanguageCode.LT, "Naujoji Kaledonija"),
			new Translation(LanguageCode.LV, "Jaunkaledonija"),
			new Translation(LanguageCode.MK, "Нова Каледонија"),
			new Translation(LanguageCode.MN, "Шинэ Каледони"),
			new Translation(LanguageCode.NB, "Ny-Caledonia"),
			new Translation(LanguageCode.NL, "Nieuw-Caledonië"),
			new Translation(LanguageCode.NN, "Ny-Caledonia"),
			new Translation(LanguageCode.PL, "Nowa Kaledonia"),
			new Translation(LanguageCode.PT, "Nova Caledônia"),
			new Translation(LanguageCode.RO, "Noua Caledonie"),
			new Translation(LanguageCode.RU, "Новая Каледония"),
			new Translation(LanguageCode.SK, "Nová Kaledónia"),
			new Translation(LanguageCode.SL, "Nova Kaledonija"),
			new Translation(LanguageCode.SR, "Нова Каледонија"),
			new Translation(LanguageCode.SV, "Nya Kaledonien"),
			new Translation(LanguageCode.TR, "Yeni Kaledonya"),
			new Translation(LanguageCode.UK, "Нова Каледонія"),
			new Translation(LanguageCode.UZ, "Yangi Kaledoniya"),
			new Translation(LanguageCode.ZH, "新喀里多尼亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.NC;
		public Alpha3Code Alpha3Code => Alpha3Code.NCL;
		public int NumericCode => 540;
		public string[] TLD => new [] { ".nc" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XPF" };
		public string[] CallingCodes => new [] { "687" };
	}
}
