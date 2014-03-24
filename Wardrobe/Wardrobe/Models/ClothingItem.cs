using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe.Models
{
    public class ClothingItem
    {
        private Dictionary<string, Tag> TagMap = new Dictionary<string, Tag>();
        
        public ClothingType ClothingType { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public Weather Weather { get; set; }

        public Uri Picture { get; set; }

        public ClothingItem(int id, string name, ClothingType clothingType, Weather weather)
        {
            Id = id;
            Name = name;
            ClothingType = clothingType;
            Weather = weather;
        }

        public void AddTag(Tag tag)
        {
            TagMap[tag.TagName] = tag;
        }

        public bool HasTag(IEnumerable<Tag> tags)
        {
            return tags.Any(tag => TagMap.ContainsKey(tag.TagName));
        }
    }
}