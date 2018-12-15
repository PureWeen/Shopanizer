using System;
using System.Collections.Generic;

namespace Shopanizer.Models
{

    public class ModelBase
    {
        public string Id { get; protected set; }
    }

    public class User : ModelBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Item> Items { get; set; }
    }
    
    public class Item : ModelBase
    {
        public Item()
        {
        }

        public Item(string userId, string name)
        {
            UserId = userId;
            Name = name;

            Id = String.Format("{0}:{1}", UserId, Name);
        }

        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Aisle Aisle { get; set; }
        public bool Need { get; set; }
    }

    
    public class Aisle
    {
        
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.ToLower().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Aisle thing = obj as Aisle;

            if (thing == null)
                return false;

            return Name.Equals(thing.Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
