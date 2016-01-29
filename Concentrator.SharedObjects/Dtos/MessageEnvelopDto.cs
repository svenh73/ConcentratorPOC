using System;

namespace Concentrator.SharedObjects.Dto
{
  public class MessageEnvelopDto<T>
  {

    public MessageEnvelopDto(T obj, int userid)
    {
      Object = obj;
      UserId = userid;

      DateCreated = DateTime.Now;
    }

    public string DataSource { get; set; }

    public T Object { get; set; }

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }
  }
}
