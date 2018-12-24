using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {id = 1, title = "Tôi thấy hoa vàng trên cỏ xanh",authorName = "Nguyễn Nhật Ánh", price=1, content = "Truyện kể về Tuổi thơ"}   ,
            new Sach {id = 2, title = "Pro ASP.NET MVC5",  authorName = "Adam Freeman",price= 3.75M, content =  "The ASP.NET MVC5 Framework is the lastest evolution of Microsoft's ASP.NET web platform."}
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
