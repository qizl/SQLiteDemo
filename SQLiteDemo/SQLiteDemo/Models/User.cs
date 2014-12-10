using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SQLiteDemo.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
    }
}
