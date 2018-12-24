using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySach.Models
{
    public class Sach
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string authorName { get; set; }
        public decimal price { get; set; }
    }

}