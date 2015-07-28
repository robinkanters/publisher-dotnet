using Publisher.ModelInterfaces;

namespace Publisher.Model
{
    class Author : IAuthor
    {
        public string Name { get; set; }
        public string Biography { get; set; }
    }
}
