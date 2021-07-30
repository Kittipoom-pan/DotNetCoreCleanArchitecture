using Newtonsoft.Json;

namespace DotNetCore.Core.Entities
{

    public partial class Campaign
    {
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }
        [JsonProperty("is_active")]
        public byte? IsActive { get; set; }
        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }
        [JsonProperty("campaign_shortcode")]
        public string CampaignShortcode { get; set; }
        [JsonProperty("campaign_sms_name")]
        public string CampaignSmsName { get; set; }
        [JsonProperty("campaign_desc")]
        public string CampaignDesc { get; set; }
    }
}
