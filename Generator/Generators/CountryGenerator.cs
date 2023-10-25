


using System.Net.Http.Json;
using System.Text;

namespace Generator.Generators;

public class CountryGenerator
{
    const string RestCountryEndpoint = "https://restcountries.com/v3.1/all";

    public async static Task Generate(string generatedFilePath)
    {
        // Read the ISO 3166-1 alpha-2 codes from api
        using var http = new HttpClient();

        var response = await http.GetFromJsonAsync<List<CountryInfo>>(RestCountryEndpoint);

        // Now generate a C# enum from this.
        var sb = new StringBuilder();

        sb.AppendLine("using System.ComponentModel;");
        sb.AppendLine();
        sb.AppendLine("namespace CountryData;");
        sb.AppendLine();
        sb.AppendLine("public enum Country");
        sb.AppendLine("{");

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Unknown - Represent the 0 value enum");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    Unknown = 0,");

        foreach(var country in response.Where(r => r.Status == "officially-assigned"))
        {
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// {country.Name.Common}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    [Description(\"{country.Name.Common}\")] {country.Cca2} = {country.Ccn3},");
        }

        sb.AppendLine("}");
        sb.AppendLine();


        // Write the file
        await File.WriteAllTextAsync($"{generatedFilePath}/Country.cs", sb.ToString());
        // TODO: We can generate additional extension methods for this enum
    }



}

internal class CountryInfo
{
    public class NameType
    {
        public string Common { get; set; }
        public string Official { get; set; }
        public Dictionary<string, NativeNameDetails> NativeName { get; set; }
    }

    public class NativeNameDetails
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class IddType
    {
        public string Root { get; set; }
        public List<string> Suffixes { get; set; }
    }

    public class Translation
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    public class DemonymsType
    {
        public string F { get; set; }
        public string M { get; set; }
    }

    public class MapsType
    {
        public string GoogleMaps { get; set; }
        public string OpenStreetMaps { get; set; }
    }

    public class GiniType
    {
        public double? Year2003 { get; set; } // You can rename "Year2003" to a more appropriate name if needed
    }

    public class CarType
    {
        public List<string> Signs { get; set; }
        public string Side { get; set; }
    }

    public class FlagsType
    {
        public string Png { get; set; }
        public string Svg { get; set; }
        public string Alt { get; set; }
    }

    public class CoatOfArmsType
    {
        public string Png { get; set; }
        public string Svg { get; set; }
    }

    public class CapitalInfoType
    {
        public List<double> Latlng { get; set; }
    }

    public class PostalCodeType
    {
        public string Format { get; set; }
        public string Regex { get; set; }
    }

    public NameType Name { get; set; }
    public List<string> Tld { get; set; }
    public string Cca2 { get; set; }
    public string Ccn3 { get; set; }
    public string Cca3 { get; set; }
    public string Cioc { get; set; }
    public bool Independent { get; set; }
    public string Status { get; set; }
    public bool UnMember { get; set; }
    public Dictionary<string, Currency> Currencies { get; set; }
    public IddType Idd { get; set; }
    public List<string> Capital { get; set; }
    public List<string> AltSpellings { get; set; }
    public string Region { get; set; }
    public string Subregion { get; set; }
    public Dictionary<string, string> Languages { get; set; }
    public Dictionary<string, Translation> Translations { get; set; }
    public List<double> Latlng { get; set; }
    public bool Landlocked { get; set; }
    public List<string> Borders { get; set; }
    // Having a hard time converting this value - skipping for now
    // public long Area { get; set; }
    public Dictionary<string, DemonymsType> Demonyms { get; set; }
    public string Flag { get; set; }
    public MapsType Maps { get; set; }
    public int Population { get; set; }
    public GiniType Gini { get; set; }
    public string Fifa { get; set; }
    public CarType Car { get; set; }
    public List<string> Timezones { get; set; }
    public List<string> Continents { get; set; }
    public FlagsType Flags { get; set; }
    public CoatOfArmsType CoatOfArms { get; set; }
    public string StartOfWeek { get; set; }
    public CapitalInfoType CapitalInfo { get; set; }
    public PostalCodeType PostalCode { get; set; }
}



