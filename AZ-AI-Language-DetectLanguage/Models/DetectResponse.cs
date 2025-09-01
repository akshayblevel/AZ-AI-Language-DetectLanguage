namespace AZ_AI_Language_DetectLanguage.Models
{
    public class DetectResponse
    {
        public string DetectedLanguage { get; set; } = "";
        public string Iso6391Name { get; set; } = "";
        public double ConfidenceScore { get; set; }
    }
}
