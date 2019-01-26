using System;

namespace Nager.Country
{
    public class CountryProvider : ICountryProvider
    {
        public ICountryInfo GetCountry(string alpha2or3Code)
        {
            throw new NotImplementedException();
        }

        public ICountryInfo GetCountry(Alpha2Code alpha2Code)
        {
            throw new NotImplementedException();
        }

        public ICountryInfo GetCountry(Alpha3Code alpha3Code)
        {
            throw new NotImplementedException();
        }
    }
}
