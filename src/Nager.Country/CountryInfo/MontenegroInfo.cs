namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Montenegro
	/// </summary>
	public class MontenegroInfo : ICountryInfo
	{
		public string CommonName => "Montenegro";
		public string OfficialName => "Montenegro";

		public Alpha2Code Alpha2Code => Alpha2Code.ME;
		public Alpha3Code Alpha3Code => Alpha3Code.MNE;
		public int NumericCode => 499;
		public string[] TLD => new [] { ".me" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AL,
			Alpha2Code.BA,
			Alpha2Code.HR,
			Alpha2Code.RS,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "382" };
	}
}
