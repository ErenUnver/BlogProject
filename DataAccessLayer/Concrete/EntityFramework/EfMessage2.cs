using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfMessage2:GenericRepository<Message2>,IMessage2Dal
    {
        public List<Message2> GetInboxWithMessageByWriter(int id)
        {
            using (var db = new Context())
            {
                return db.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }
        public List<Message2> GetSendboxWithMessageByWriter(int id)
        {
            using (var db = new Context())
            {
                return db.Message2s.Include(x => x.ReceiverID).Where(x => x.SenderID == id).ToList();
            }
        }
    }
}
