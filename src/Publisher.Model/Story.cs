using System;
using System.Collections.Generic;
using Publisher.ModelInterfaces;

namespace Publisher.Model
{
    public class Story : IStory, ITaggable
    {
        public void Tag(IPostTag tag)
        {
            Tags.Add(tag);
        }

        public List<IPostTag> Tags { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public IAuthor Author { get; set; }
        public string Description { get; set; }
    }
}
