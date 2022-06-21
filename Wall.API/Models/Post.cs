namespace Wall.API.Models
{
    public class Post : BaseModel
    {
        public string TextContent { get; set; }
        public int MoodState { get; set; } //Emotional mood of user
    }
}
