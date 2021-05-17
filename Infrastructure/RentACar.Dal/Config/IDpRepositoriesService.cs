using RentACar.Application.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentACar.Dal.Dapper
{
    public interface IDpRepositoriesService : IApplicationService
    {
        void conClose();
        void conOpen();
        TRes GetQuery<TRes>(string Query);
        IEnumerable<TRes> GetQueryList<TRes>(string Query);
        Task<TRes> GetSp<TReq, TRes>(string StoredProcedure, TReq ObjParam);
        Task<IEnumerable<TRes>> GetSpList<TReq, TRes>(string StoredProcedure, TReq ObjParam);
        IEnumerable<TRes> GetSqlList<TReq, TRes>(string Sql, TReq ObjParam);
        int SaveSpOutputEffectedCount<TReq>(string StoredProcedure, TReq ObjParam);
    }
}