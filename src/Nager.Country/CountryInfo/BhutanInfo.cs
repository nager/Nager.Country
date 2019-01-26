namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bhutan
	/// </summary>
	public class BhutanInfo : ICountryInfo
	{
		public string CommonName => "Bhutan";
		public string OfficialName => "Kingdom of Bhutan";

		public Alpha2Code Alpha2Code => Alpha2Code.BT;
		public Alpha3Code Alpha3Code => Alpha3Code.BTN;
		public int NumericCode => 064;
		public string[] TLD => new [] { ".bt" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthernAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
			Alpha2Code.IN,
		};

		public string[] Currencies => new [] { "BTN", "INR" };
		public string[] CallingCodes => new [] { "975" };
	}
}
