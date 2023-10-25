
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Generator.Generators;

public static class CurrencyGenerator
{
    const string DatahubEnpoint = "https://datahub.io/core/currency-codes/r/codes-all.json";

    public async static Task Generate(string generatedFilePath)
    {
        // Read the ISO 3166-1 alpha-2 codes from api
        using var http = new HttpClient();

        var response = await http.GetFromJsonAsync<List<CurrencyInfo>>(DatahubEnpoint);

        // Now generate a C# enum from this.
        var sb = new StringBuilder();

        sb.AppendLine("using System.ComponentModel;");
        sb.AppendLine();
        sb.AppendLine("namespace CurrencyData;");
        sb.AppendLine();
        sb.AppendLine("public enum Currency");
        sb.AppendLine("{");

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Unknown - Represent the 0 value enum");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    Unknown = 0,");

        foreach(var currency in response.Where(r => r.NumericCode is not null).Distinct())
        {

            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// {currency.Currency}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    [Description(\"{EscapeString(currency.Currency)}\")] {currency.AlphabeticCode} = {Convert.ToInt32(currency.NumericCode)},");
        }

        sb.AppendLine("}");
        sb.AppendLine();


        // Write the file
        await File.WriteAllTextAsync($"{generatedFilePath}/Currency.cs", sb.ToString());
    }

    private static string EscapeString(string input)
    {
        return input.Replace("\"", "\\\"");
    }
}

internal class CurrencyInfo : IEquatable<CurrencyInfo>
{
    public string AlphabeticCode { get; set; }
    public string Currency { get; set; }
    public string Entity { get; set; }
    public string MinorUnit { get; set; }
    public decimal? NumericCode { get; set; }

    public bool Equals(CurrencyInfo obj)
    {
        return NumericCode == obj.NumericCode;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as CurrencyInfo);
    }

    public override int GetHashCode()
    {
        return Convert.ToInt32(NumericCode);
    }
}

