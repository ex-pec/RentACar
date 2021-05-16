using System.Collections.Generic;

namespace RentACar.MVC.Models.Response
{
    public class Response<T> where T : new()
    {
        public Response()
        {
            this.Data = new T();
        }

        public bool Flag { get; set; } = false;

        public string Message { get; set; } = "";

        public T Data { get; set; }
    }

    public class ResponseList<T> where T : new()
    {
        public ResponseList()
        {
            Data = new List<Response<T>>();
        }

        public bool Flag { get; set; } = false;

        public string Message { get; set; } = "";

        public List<Response<T>> Data { get; set; }
    }
}