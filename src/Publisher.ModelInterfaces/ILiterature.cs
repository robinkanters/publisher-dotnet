using System;

namespace Publisher.ModelInterfaces
{
    public interface ILiterature
    {
        string Title { get; set; }
        string Content { get; set; }
        DateTime PublishDate { get; set; }
        IAuthor Author { get; set; }
    }
}
