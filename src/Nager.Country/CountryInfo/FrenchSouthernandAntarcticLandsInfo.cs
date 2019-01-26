namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// French Southern and Antarctic Lands
	/// </summary>
	public class FrenchSouthernandAntarcticLandsInfo : ICountryInfo
	{
		public string CommonName => "French Southern and Antarctic Lands";
		public string OfficialName => "Territory of the French Southern and Antarctic Lands";

		public Alpha2Code Alpha2Code => Alpha2Code.TF;
		public Alpha3Code Alpha3Code => Alpha3Code.ATF;
		public int NumericCode => 260;
		public string[] TLD => new [] { ".tf" };

		public Region Region => Region.None;
		public SubRegion SubRegion => SubRegion.None;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new string[0];
	}
}
