using Newtonsoft.Json;

namespace VisualStudioSummit.Models
{
    public class Scores
    {
        [JsonProperty(PropertyName = "anger")]
        public decimal Anger { get; set; }

        [JsonProperty(PropertyName = "contempt")]
        public decimal Contempt { get; set; }

        [JsonProperty(PropertyName = "disgust")]
        public decimal Disgust { get; set; }

        [JsonProperty(PropertyName = "fear")]
        public decimal Fear { get; set; }

        [JsonProperty(PropertyName = "happiness")]
        public decimal Happiness { get; set; }

        [JsonProperty(PropertyName = "neutral")]
        public decimal Neutral { get; set; }

        [JsonProperty(PropertyName = "sadness")]
        public decimal Sadness { get; set; }

        [JsonProperty(PropertyName = "surprise")]
        public decimal Surprise { get; set; }
    }
}
