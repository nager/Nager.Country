namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Jordan
	/// </summary>
	public class JordanInfo : ICountryInfo
	{
		public string CommonName => "Jordan";
		public string OfficialName => "Hashemite Kingdom of Jordan";

		public Alpha2Code Alpha2Code => Alpha2Code.JO;
		public Alpha3Code Alpha3Code => Alpha3Code.JOR;
		public int NumericCode => 400;
		public string[] TLD => new [] { ".jo", "الاردن." };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IQ,
			Alpha2Code.IL,
			Alpha2Code.SA,
			Alpha2Code.SY,
		};

		public string[] Currencies => new [] { "JOD" };
		public string[] CallingCodes => new [] { "962" };
	}
}
