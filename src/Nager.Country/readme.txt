
████████ ██   ██  █████  ███    ██ ██   ██     ██    ██  ██████  ██    ██
   ██    ██   ██ ██   ██ ████   ██ ██  ██       ██  ██  ██    ██ ██    ██
   ██    ███████ ███████ ██ ██  ██ █████         ████   ██    ██ ██    ██
   ██    ██   ██ ██   ██ ██  ██ ██ ██  ██         ██    ██    ██ ██    ██
   ██    ██   ██ ██   ██ ██   ████ ██   ██        ██     ██████   ██████


Thank you for using this project. This project is completely free for commercial use.

However, if you use our project commercially we would like you to support us with a sponsorship.
The maintenance and support costs time and we would like to ensure this for the future with your help.
You can easily support us via the Github Sponsor function. https://github.com/sponsors/nager

We would also be very happy about a GitHub Star ★

Project Source: https://github.com/nager/Nager.Country



Examples of use:

Get CountryInfo for Germany via ISO-3166-1 Alpha-2
══════════════════════════════════════════════════════════════════════════════════════════════════════

    ICountryProvider countryProvider = new CountryProvider();
    var countryInfo = countryProvider.GetCountry("de");
    //countryInfo.CommonName -> Germany
    //countryInfo.Alpha3Code -> DEU
    //countryInfo.NumericCode -> 276
    //countryInfo.Region -> Europe
    //countryInfo.SubRegion -> WesternEurope
    //countryInfo...

Get CountryInfo for Germany via Alpha2Code
══════════════════════════════════════════════════════════════════════════════════════════════════════

    ICountryProvider countryProvider = new CountryProvider();
    var countryInfo = countryProvider.GetCountry(Alpha2Code.DE);
    //countryInfo.CommonName -> Germany
    //countryInfo.Alpha3Code -> DEU
    //countryInfo.NumericCode -> 276
    //countryInfo.Region -> Europe
    //countryInfo.SubRegion -> WesternEurope
    //countryInfo...

Get CountryInfo for Germany via CommonName
══════════════════════════════════════════════════════════════════════════════════════════════════════

    ICountryProvider countryProvider = new CountryProvider();
    var countryInfo = countryProvider.GetCountryByName("Germany");
    //countryInfo.Alpha2Code -> DE
    //countryInfo.Alpha3Code -> DEU
    //countryInfo.NumericCode -> 276
    //countryInfo.Region -> Europe
    //countryInfo.SubRegion -> WesternEurope
    //countryInfo..