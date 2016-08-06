using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EF;

namespace DAL
{
    /// <summary>
    /// 信息数据访问类
    /// </summary>
    public class MessageDAL
    {
        //public static List<Message> GetMessages()
        //{
        //    List<Message> messages = new List<Message>();
        //    string sql = "SELECT * FROM dbo.[Message] WITH(NOLOCK)";
        //    DataTable dt = SqlHelper.ExecuteQuery(sql);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ConvertToEntity(messages, dr);
        //    }
        //    return messages;
        //}

        //private static void ConvertToEntity(List<Message> messages, DataRow dr)
        //{
        //    Message m = new Message();
        //    m.Id = dr["id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["id"]);
        //    m.MessageTitle = dr["MessageTitle"] == DBNull.Value ? string.Empty : dr["MessageTitle"].ToString();
        //    m.MessageContent = dr["MessageContent"] == DBNull.Value ? string.Empty : dr["MessageContent"].ToString();
        //    m.PostTime = dr["PostTime"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["PostTime"]);
        //    messages.Add(m);
        //}

        public static List<Message> GetMessages()
        {
            MessageEntities context = new MessageEntities();
            return context.Messages.ToList();
        }

        public static bool Add(Message message)
        {
            MessageEntities context = new MessageEntities();
            context.Messages.AddObject(message);
            return context.SaveChanges() > 0 ? true : false;
        }

        public static bool Delete(int id)
        {
            MessageEntities context = new MessageEntities();
            Message message = new Message();
            message.id = id;
            context.Messages.Attach(message);
            context.ObjectStateManager.ChangeObjectState(message, EntityState.Deleted);
            return context.SaveChanges() > 0 ? true : false;
        }

        public static bool Update(Message message)
        {
            MessageEntities context = new MessageEntities();
            context.Messages.Attach(message);
            context.ObjectStateManager.ChangeObjectState(message, EntityState.Modified);
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
