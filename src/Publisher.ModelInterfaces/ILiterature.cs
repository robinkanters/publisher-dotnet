using System;

namespace Publisher.ModelInterfaces
{
    public interface ILiterature
    {
        string Title { get; }
        string Content { get; }
        DateTime PublishDate { get; }
        IAuthor Author { get; }
    }
}
