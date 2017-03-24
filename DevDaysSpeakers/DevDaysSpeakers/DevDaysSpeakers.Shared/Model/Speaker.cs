using Microsoft.WindowsAzure.MobileServices;

namespace DevDaysSpeakers.Model
{
    public class Speaker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }

        [Version]
        public string AzureVersion { get; set; }
    }
}
