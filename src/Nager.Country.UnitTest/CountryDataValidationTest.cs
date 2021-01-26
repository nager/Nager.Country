using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nager.Country.UnitTest
{
    [TestClass]
    public class CountryDataValidationTest
    {
        //Very popular country project on github
        //https://github.com/mledoze/countries
        [TestMethod]
        public async Task CompareWithMledozeCountryProject()
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync("https://raw.githubusercontent.com/mledoze/countries/master/dist/countries.json");
                var items = JsonConvert.DeserializeObject<MledozeCountry[]>(json);

                ICountryProvider countryProvider = new CountryProvider();
                foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
                {
                    var countryInfo = countryProvider.GetCountry(countryCode);
                    Trace.WriteLine($"check {countryInfo.CommonName}");
                    if (countryInfo == null)
                    {
                        Assert.Fail($"countryInfo is null for {countryCode}");
                    }

                    var compareCountry = items.FirstOrDefault(o => o.Cca2.Equals(countryInfo.Alpha2Code.ToString()));
                    if (compareCountry == null)
                    {
                        Assert.Inconclusive(countryCode.ToString());
                        continue;
                    }

                    //TODO: Check how can check after change structure
                    //countryInfo.Currencies
                    //    .Should()
                    //    .BeEquivalentTo(compareCountry.Currencies.ChildrenToke.Name.ToArray(),
                    //    because: $"{countryCode} {string.Join(",", compareCountry.Currencies.Keys)}  {string.Join(",", countryInfo.Currencies)}");                   

                    Assert.AreEqual(compareCountry.Ccn3, countryInfo.NumericCode, $"wrong numeric code by {countryCode} {countryInfo.CommonName}");
                    Assert.AreEqual(compareCountry.Region, countryInfo.Region.ToString(), $"wrong region by {countryCode} {countryInfo.CommonName}");
                    Assert.AreEqual(this.AdaptMledozeSubRegion(compareCountry.Subregion), this.GetSubRegion(countryInfo.SubRegion), $"wrong subregion by {countryCode} {countryInfo.CommonName}");
                    Assert.AreEqual(compareCountry.Cca3, countryInfo.Alpha3Code.ToString(), $"wrong alpha 3 code by {countryCode} {countryInfo.CommonName}");
                    Assert.AreEqual(compareCountry.Name.Common, countryInfo.CommonName.ToString(), $"wrong common name by {countryCode} {countryInfo.CommonName}");
                }
            }
        }

        private string AdaptMledozeSubRegion(string subregion)
        {
            return subregion.Replace(" ", string.Empty).Replace("-", string.Empty).ToLower();
        }

        private string GetSubRegion(SubRegion subRegion)
        {
            if (subRegion == SubRegion.None)
            {
                return string.Empty;
            }

            return subRegion.ToString().ToLower();
        }

        public class MledozeCountry
        {
            public Name Name { get; set; }
            public string[] Tld { get; set; }
            public string Cca2 { get; set; }
            public int? Ccn3 { get; set; }
            public string Cca3 { get; set; }
            public string Cioc { get; set; }
            public bool? Independent { get; set; }
            public string Status { get; set; }
            public dynamic Currencies { get; set; }
            public string[] CallingCode { get; set; }
            public string[] Capital { get; set; }
            public string[] AltSpellings { get; set; }
            public string Region { get; set; }
            public string Subregion { get; set; }
            //public Languages languages { get; set; }
            //public Dictionary<string, NameNative> translations { get; set; }
            public List<double> LatLng { get; set; }
            public string Demonym { get; set; }
            public bool Landlocked { get; set; }
            public string[] Borders { get; set; }
            public double Area { get; set; }
            public string Flag { get; set; }
        }

        public class Name
        {
            public string Common { get; set; }
            public string Official { get; set; }
            public Dictionary<string, NameNative> Native { get; set; }
        }

        public class NameNative
        {
            public string Common { get; set; }
            public string Official { get; set; }
        }

        public class Currency
        {
            public string Name { get; set; }
            public string Symbol { get; set; }
        }
    }
}
