using RentACar.MVC.Models.Response;

namespace RentACar.MVC.Helper
{
    public class ResponseHelper
    {
        public Response<T> NullCheck<T>(T obj, string errorMessage) where T : new()
        {
            var res = new Response<T>();
            res.Data = obj;
            if (obj == null)
                //if null set error and send
                this.SetError(res, errorMessage);
            else
                //if not null set true and send
                this.SetSuccess(res);

            return res;
        }

        /// <summary>
        /// fill error response model 
        /// </summary>
        /// <typeparam name="T">response data type</typeparam>
        /// <param name="res"> response model</param>
        /// <param name="obj">response data</param>
        /// <param name="errorMessage">error message</param>
        private void SetError<T>(Response<T> res, string errorMessage) where T : new()
        {
            res.Flag = false;
            res.Message = errorMessage;
        }

        /// <summary>
        /// fill error response model 
        /// </summary>
        /// <typeparam name="T">response data type</typeparam>
        /// <param name="res"> response model</param>
        /// <param name="obj">response data</param>
        /// <param name="errorMessage">error message</param>
        private void SetSuccess<T>(Response<T> res) where T : new()
        {
            res.Flag = true;
        }
    }
}