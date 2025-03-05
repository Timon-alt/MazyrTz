using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazyrTz.database
{
    [Table("RawMaterials")]
    public class RawMaterials : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("bricks_count")]
        public double bricks_count { get; set; }

        [Column("cost")]
        public double cost { get; set; }

        [Column("adress")]
        public string adress { get; set; }
    }
}
