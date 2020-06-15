using Demo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo3.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{ Id = 1, Title= "Tôi thấy hoa vàng trên cỏ xanh", AutherName = "Nguyễn Ngọc Ánh", Price = 1, Content = "Truyện kể về tuổi thơ của tôi..." },
            new Sach{ Id = 2, Title= "Tiếng Gọi Nơi Hoang Dã", AutherName = "Jack", Price = 3.5M, Content = "Truyện kể về con chó Buck bị bán qua nhiều đời chủ..." },
        };

        public IEnumerable<Sach>GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
