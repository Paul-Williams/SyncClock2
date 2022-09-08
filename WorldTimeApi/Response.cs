using Newtonsoft.Json;

namespace WorldTimeApi;

// See: https://worldtimeapi.org/pages/schema

public class Response
{
  [JsonProperty(PropertyName = "abbreviation")]
  public string Abbreviation { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "client_ip")]
  public string ClientIP { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "datetime")]
  public DateTime LocalDateTime { get; set; } //= string.Empty;

  [JsonProperty(PropertyName = "day_of_week")]
  public int DayOfWeek { get; set; }

  [JsonProperty(PropertyName = "day_of_year")]
  public int DayOfYear { get; set; }

  [JsonProperty(PropertyName = "dst")]
  public bool IsDaylightSaving { get; set; }

  [JsonProperty(PropertyName = "dst_from")]
  public string DaylightSavingFrom { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "dst_offset")]
  public int DaylightSavingOffset { get; set; }

  [JsonProperty(PropertyName = "dst_until")]
  public string DaylightSavingUntil { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "raw_offset")]
  public int UtcOffsetSeconds { get; set; }

  [JsonProperty(PropertyName = "timezone")]
  public string Timezone { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "unixtime")]
  public long UnixTime { get; set; }

  [JsonProperty(PropertyName = "utc_datetime")]
  public string UtcDateTime { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "utc_offset")]
  public string UtcOffset { get; set; } = string.Empty;

  [JsonProperty(PropertyName = "week_number")]
  public int WeekNumber { get; set; }

}


