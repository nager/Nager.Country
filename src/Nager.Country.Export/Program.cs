using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nager.Country.Export
{
    class Program
    {
        static void Main(string[] args)
        {
            var exportDirectory = "export";

            if (!Directory.Exists(exportDirectory))
            {
                Directory.CreateDirectory(exportDirectory);
            }

            var jsonSerializerOptions = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new JsonStringEnumConverterWithAttributeSupport(null, true, true, true, true)
                },
                WriteIndented = true
            };

            var countryProvider = new CountryProvider();
            var countries = countryProvider.GetCountries();
            foreach (var country in countries)
            {
                var jsonData = JsonSerializer.SerializeToUtf8Bytes(country, jsonSerializerOptions);
                File.WriteAllBytesAsync($"{exportDirectory}/{country.Alpha2Code}.json", jsonData).GetAwaiter().GetResult();
            }

            Console.WriteLine("Json export done");
        }
    }
}
