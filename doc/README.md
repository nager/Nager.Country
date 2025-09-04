# 🌍 Nager.Country – Worldwide Country Information

**Nager.Country** provides a comprehensive dataset of **worldwide country information**, designed for developers who need reliable and structured country-related data.

The dataset includes **250 countries and territories** with detailed information such as:

- ✅ Official country names  
- 🌐 ISO 3166 Alpha-2, Alpha-3, and numeric country codes  
- 💱 Associated currencies and ISO 4217 currency codes  
- 🗣️ Official and spoken languages (ISO 639)  
- 🌍 Continent and subregion classification  
- 🌐 Country borders
- 🌏 Translations in multiple languages

## 🌐 Optional Package – `Nager.Country.Translation`

> If you need the translations of the countries you will find in the further nuget package [Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation)

## Code Examples

### Get CountryInfo for Germany via ISO-3166-1 Alpha-2
══════════════════════════════════════════════════════════════════════════════════════════════════════

```cs
ICountryProvider countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountry("de");
//countryInfo.CommonName -> Germany
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Get CountryInfo for Germany via Alpha2Code

```cs
ICountryProvider countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountry(Alpha2Code.DE);
//countryInfo.CommonName -> Germany
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Get CountryInfo for Germany via CommonName

```cs
ICountryProvider countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountryByName("Germany");
//countryInfo.Alpha2Code -> DE
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo..
```

### Get all available countries

Retrieve a full list of all 250 countries and territories.

```cs
var countryProvider = new CountryProvider();
var countries = countryProvider.GetCountries();
```