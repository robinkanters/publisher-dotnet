using Publisher.ModelInterfaces;

namespace Publisher.Model
{
    public class Poem : Literature, IPoem
    {
        public string Metaphor { get; set; }
    }
}
