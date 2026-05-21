using SQLite;

namespace POHuntsville
{
    public class Banner
    {
        [PrimaryKey]
        public string BannerName { get; set; }
        public string BannerURL { get; set; }
    }
}
