﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager:IMessage2Service
    {
        IMessage2Dal _messageDal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetListWithMessageByWriter(id);
        }
        public List<Message2> GetListAll()
        {
            return _messageDal.GetListAll();
        }
        public void Insert(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}