using System;
using System.Collections.Generic;
using Publisher.ModelInterfaces;

namespace Publisher.Model
{
    public abstract class Literature : ITaggable, ILiterature
    {
        private readonly List<IPostTag> _tags = new List<IPostTag>();  
        public List<IPostTag> Tags => new List<IPostTag>(_tags);

        public void Tag(IPostTag tag)
        {
            _tags.Add(tag);
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public IAuthor Author { get; set; }
    }
}
