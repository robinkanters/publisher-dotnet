using Publisher.ModelInterfaces;

namespace Publisher.Model
{
    public class Story : Literature, IStory
    {
        public string Description { get; set; }
    }
}
