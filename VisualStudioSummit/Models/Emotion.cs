using Newtonsoft.Json;

namespace VisualStudioSummit.Models
{
    public class Emotion
    {
        [JsonProperty(PropertyName = "faceRectangle")]
        public FaceRetangle FaceRetangle { get; set; }

        [JsonProperty(PropertyName = "scores")]
        public Scores Scores { get; set; }
    }
}
