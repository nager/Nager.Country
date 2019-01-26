namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Lebanon
	/// </summary>
	public class LebanonInfo : ICountryInfo
	{
		public string CommonName => "Lebanon";
		public string OfficialName => "Lebanese Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.LB;
		public Alpha3Code Alpha3Code => Alpha3Code.LBN;
		public int NumericCode => 422;
		public string[] TLD => new [] { ".lb" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IL,
			Alpha2Code.SY,
		};

		public string[] Currencies => new [] { "LBP" };
		public string[] CallingCodes => new [] { "961" };
	}
}
