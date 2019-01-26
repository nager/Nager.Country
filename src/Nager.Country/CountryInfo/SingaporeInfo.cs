namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Singapore
	/// </summary>
	public class SingaporeInfo : ICountryInfo
	{
		public string CommonName => "Singapore";
		public string OfficialName => "Republic of Singapore";

		public Alpha2Code Alpha2Code => Alpha2Code.SG;
		public Alpha3Code Alpha3Code => Alpha3Code.SGP;
		public int NumericCode => 702;
		public string[] TLD => new [] { ".sg", ".新加坡", ".சிங்கப்பூர்" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "SGD" };
		public string[] CallingCodes => new [] { "65" };
	}
}
