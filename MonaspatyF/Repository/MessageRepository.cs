using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonaspatyF.Models;

namespace MonaspatyF.Repository
{
    public class MessageRepository
    {
        MonaspatyContext db;
        public MessageRepository(MonaspatyContext db)
        {
            this.db = db;
        }

        public void add(Message message)
        {
            db.Messages.Add(message);
            db.SaveChanges();
        }

        public List<Message> getMessage()
        {
            return db.Messages.ToList();
        }

        public Message getById(int id)
        {
            return db.Messages.Find(id);
        } 
        
        public void Delete(int id)
        {
            db.Messages.Remove(getById(id));
            db.SaveChanges();
        }
    }
}
