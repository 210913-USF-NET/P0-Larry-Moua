using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Photocard
    {
        public int Id { get; set; }
        public int StageNameId { get; set; }
        public int GroupNameId { get; set; }
        public int AlbumId { get; set; }
        public string SetId { get; set; }
        public decimal Price { get; set; }
        public int PointPrice { get; set; }
        public int PointValue { get; set; }
        public int Stock { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist GroupName { get; set; }
        public virtual Idol StageName { get; set; }
    }
}
