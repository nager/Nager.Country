namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// United Arab Emirates
	/// </summary>
	public class UnitedArabEmiratesInfo : ICountryInfo
	{
		public string CommonName => "United Arab Emirates";
		public string OfficialName => "United Arab Emirates";

		public Alpha2Code Alpha2Code => Alpha2Code.AE;
		public Alpha3Code Alpha3Code => Alpha3Code.ARE;
		public int NumericCode => 784;
		public string[] TLD => new [] { ".ae", "امارات." };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.OM,
			Alpha2Code.SA,
		};

		public string[] Currencies => new [] { "AED" };
		public string[] CallingCodes => new [] { "971" };
	}
}
