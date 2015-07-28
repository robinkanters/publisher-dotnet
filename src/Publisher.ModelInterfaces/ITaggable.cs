using System.Collections.Generic;

namespace Publisher.ModelInterfaces
{
    public interface ITaggable
    {
        List<IPostTag> Tags { get; }
        void Tag(IPostTag tag);
    }
}
