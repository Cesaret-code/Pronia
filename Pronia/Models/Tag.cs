﻿namespace Pronia.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }

        public List<TagProducts>? TagProducts { get; set; }
    }
}
