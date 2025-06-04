using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Nager.Country.UnitTest
{
    [TestClass]
    public class CurrencyTest
    {
        private ICurrency[] GetCurrencies()
        {
            var type = typeof(ICurrency);
            var currencyClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

            var currenies = new List<ICurrency>();
            foreach (var currencyClass in currencyClasses)
            {
                var currency = (ICurrency)Activator.CreateInstance(currencyClass);
                currenies.Add(currency);
            }

            return currenies.ToArray();
        }

        [TestMethod]
        public void CheckCurrencyIntegrityTest()
        {
            var currenies = this.GetCurrencies();

            //var items = currenies.Where(currency => currency.IsoCode is not null)
            //    .GroupBy(currency => currency.IsoCode)
            //    .Select(grouped => new { grouped.Key, Count = grouped.Count() })
            //    .Where(o => o.Count > 1);

            var detectDuplicateIsoCode = currenies
                .GroupBy(currency => currency.IsoCode)
                .Any(grouped => grouped.Count() > 1);

            Assert.IsFalse(detectDuplicateIsoCode, "detect duplicate IsoCode");

            var detectDuplicateNumericCode = currenies
                .GroupBy(currency => currency.NumericCode)
                .Any(grouped => grouped.Count() > 1);

            Assert.IsFalse(detectDuplicateNumericCode, "detect duplicate NumericCode");
        }

        [TestMethod]
        public void CompareCurrencyInfoWithNetFrameworkTest()
        {
            //Compare with https://en.wikipedia.org/wiki/Currency_symbol

            var currenies = this.GetCurrencies();

            var frameworkCurrencies = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(ci => ci.Name).Distinct()
                .Select(id => new RegionInfo(id))
                .GroupBy(r => r.ISOCurrencySymbol)
                .Select(g => g.ToList())
                .Select(r => new
                {
                    FullObject = r,
                    r.First().ISOCurrencySymbol,
                    r.First().CurrencyEnglishName,
                    r.First().CurrencySymbol,
                }).ToList();

            var counter = 0;

            foreach (var frameworkCurrency in frameworkCurrencies)
            {
                var currency = currenies.SingleOrDefault(curreny => curreny.IsoCode == frameworkCurrency.ISOCurrencySymbol);
                if (currency is null)
                {
                    continue;
                }

                if (currency.Symbol != frameworkCurrency.CurrencySymbol)
                {
                    counter++;
                    Trace.WriteLine($"Detect currency distinction IsoCode:{currency.IsoCode} Symbol:{currency.Symbol} .net framework symbol:{frameworkCurrency.CurrencySymbol}");
                }
            }

            Trace.WriteLine($"Found {counter} distinctions");
        }
    }
}
