namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// British Virgin Islands
	/// </summary>
	public class BritishVirginIslandsInfo : ICountryInfo
	{
		public string CommonName => "British Virgin Islands";
		public string OfficialName => "Virgin Islands";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جزر العذراء البريطانية"),
			new Translation(LanguageCode.AZ, "Britaniyanın Virgin adaları"),
			new Translation(LanguageCode.BE, "Брытанскія Віргінскія астравы"),
			new Translation(LanguageCode.BG, "Британски Вирджински острови"),
			new Translation(LanguageCode.BS, "Britanska Djevičanska Ostrva"),
			new Translation(LanguageCode.CA, "Verges Britàniques, illes"),
			new Translation(LanguageCode.CS, "Britské Panenské ostrovy"),
			new Translation(LanguageCode.DA, "Britiske Jomfruøer"),
			new Translation(LanguageCode.DE, "Britische Jungferninseln"),
			new Translation(LanguageCode.EL, "Βρετανικές Παρθένοι Νήσοι"),
			new Translation(LanguageCode.EN, "Virgin Islands, British"),
			new Translation(LanguageCode.ES, "Islas Vírgenes británicas"),
			new Translation(LanguageCode.ET, "Briti Neitsisaared"),
			new Translation(LanguageCode.FA, "جزایر ویرجین بریتانیا"),
			new Translation(LanguageCode.FI, "Brittiläiset Neitsytsaaret"),
			new Translation(LanguageCode.FR, "Îles vierges britanniques"),
			new Translation(LanguageCode.HE, "איי הבתולה הבריטיים"),
			new Translation(LanguageCode.HR, "Britanski Djevičanski otoci"),
			new Translation(LanguageCode.HU, "Brit Virgin-szigetek"),
			new Translation(LanguageCode.HY, "Բրիտանական Վիրջինյան կղզիներ"),
			new Translation(LanguageCode.ID, "Virgin Islands, British"),
			new Translation(LanguageCode.IT, "Isole Vergini Britanniche"),
			new Translation(LanguageCode.JA, "イギリス領ヴァージン諸島"),
			new Translation(LanguageCode.KA, "ბრიტანეთის ვირჯინის კუნძულები"),
			new Translation(LanguageCode.KK, "Британдық Виргин аралдары"),
			new Translation(LanguageCode.KO, "영국령 버진 아일랜드"),
			new Translation(LanguageCode.KY, "Виргин аралдары (Британия)"),
			new Translation(LanguageCode.LT, "Didžiosios Britanijos Mergelių Salos"),
			new Translation(LanguageCode.LV, "Britu Virdžīnas"),
			new Translation(LanguageCode.MK, "Британски Девствени Острови"),
			new Translation(LanguageCode.MN, "Британийн Виржиний Арлууд"),
			new Translation(LanguageCode.NB, "Jomfruøyene (Britisk)"),
			new Translation(LanguageCode.NL, "Maagdeneilanden, Britse"),
			new Translation(LanguageCode.NN, "Jomfruøyane (Britisk)"),
			new Translation(LanguageCode.PL, "Brytyjskie Wyspy Dziewicze"),
			new Translation(LanguageCode.PT, "Ilhas Virgens Britânicas"),
			new Translation(LanguageCode.RO, "Insulele Virgine Britanice"),
			new Translation(LanguageCode.RU, "Виргинские Острова (Великобритания)"),
			new Translation(LanguageCode.SK, "Britské Panenské ostrovy"),
			new Translation(LanguageCode.SL, "Britanski Deviški otoki"),
			new Translation(LanguageCode.SR, "Британска Девичанска Острва"),
			new Translation(LanguageCode.SV, "Brittiska Jungfruöarna"),
			new Translation(LanguageCode.TR, "Britanya Virjin Adaları"),
			new Translation(LanguageCode.UK, "Британські Віргінські Острови"),
			new Translation(LanguageCode.UZ, "Britaniya Virgin orollari"),
			new Translation(LanguageCode.ZH, "英属维尔京群岛"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.VG;
		public Alpha3Code Alpha3Code => Alpha3Code.VGB;
		public int NumericCode => 092;
		public string[] TLD => new [] { ".vg" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1284" };
	}
}
