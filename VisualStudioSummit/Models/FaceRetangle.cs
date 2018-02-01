using Newtonsoft.Json;

namespace VisualStudioSummit.Models
{
    public class FaceRetangle
    {
        [JsonProperty(PropertyName = "top")]
        public string Top { get; set; }

        [JsonProperty(PropertyName = "left")]
        public string Left { get; set; }

        [JsonProperty(PropertyName = "width")]
        public string Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string Heigth { get; set; }
    }
}
