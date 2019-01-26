namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Qatar
	/// </summary>
	public class QatarInfo : ICountryInfo
	{
		public string CommonName => "Qatar";
		public string OfficialName => "State of Qatar";

		public Alpha2Code Alpha2Code => Alpha2Code.QA;
		public Alpha3Code Alpha3Code => Alpha3Code.QAT;
		public int NumericCode => 634;
		public string[] TLD => new [] { ".qa", "قطر." };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.SA,
		};

		public string[] Currencies => new [] { "QAR" };
		public string[] CallingCodes => new [] { "974" };
	}
}
