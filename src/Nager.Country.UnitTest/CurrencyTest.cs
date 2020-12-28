using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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

            //var items = currenies.Where(currency => currency.IsoCode != null)
            //    .GroupBy(currency => currency.IsoCode)
            //    .Select(grouped => new { grouped.Key, Count = grouped.Count() })
            //    .Where(o => o.Count > 1);

            var detectDuplicateIsoCode = currenies.Where(currency => currency.IsoCode != null)
                .GroupBy(currency => currency.IsoCode)
                .Any(grouped => grouped.Count() > 1);

            Assert.IsFalse(detectDuplicateIsoCode, "detect duplicate IsoCode");

            var detectDuplicateNumericCode = currenies.Where(currency => currency.NumericCode != null)
                .GroupBy(currency => currency.NumericCode)
                .Any(grouped => grouped.Count() > 1);

            Assert.IsFalse(detectDuplicateNumericCode, "detect duplicate NumericCode");
        }

        [TestMethod]
        public void CompareCurrencyInfoWithNetFrameworkTest()
        {
            var currenies = this.GetCurrencies();

            var frameworkCurrencies = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(ci => ci.LCID).Distinct()
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

            foreach (var frameworkCurrency in frameworkCurrencies)
            {
                var currency = currenies.SingleOrDefault(curreny => curreny.IsoCode == frameworkCurrency.ISOCurrencySymbol);
                if (currency == null)
                {
                    continue;
                }

                if (currency.Symbol != frameworkCurrency.CurrencySymbol)
                {
                    Trace.WriteLine($"Detect currency distinction IsoCode:{currency.IsoCode} Symbol:{currency.Symbol} .net framework symbol:{frameworkCurrency.CurrencySymbol}");
                }
            }
        }
    }
}
