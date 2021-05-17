using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Dapper
{
    public class DpRepositoriesService : IDpRepositoriesService
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString;
        public DpRepositoriesService()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);

        }

        public void conOpen()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void conClose()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        //Spler için parametreye göre FirstOrDefault çekme fonksiyonu
        public async Task<TRes> GetSp<TReq, TRes>(string StoredProcedure, TReq ObjParam)
        {
            TRes result = default;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                conOpen();
                result = (await sqlConnection.QueryAsync<TRes>(StoredProcedure, ObjParam, commandTimeout: 180,
                  commandType: CommandType.StoredProcedure)).FirstOrDefault();
                conClose();

            }
            catch (Exception ex)
            {

            }

            return result;
        }
        //Spler için parametreye göre ToList çekme fonksiyonu
        public async Task<IEnumerable<TRes>> GetSpList<TReq, TRes>(string StoredProcedure, TReq ObjParam)
        {
            sqlConnection = new SqlConnection(connectionString);
            IEnumerable<TRes> result = default;
            try
            {
                conOpen();
                result = (await sqlConnection.QueryAsync<TRes>(StoredProcedure, ObjParam, commandTimeout: 180,
                    commandType: CommandType.StoredProcedure)).ToList();
                conClose();
            }
            catch (Exception ex)
            {
                conClose();
            }

            return result;
        }
        //Sql Text için parametreye göre liste çekme fonksiyonu
        public IEnumerable<TRes> GetSqlList<TReq, TRes>(string Sql, TReq ObjParam)
        {
            sqlConnection = new SqlConnection(connectionString);
            //var args = new DynamicParameters(ObjParam);
            IEnumerable<TRes> result = default;
            try
            {
                conOpen();
                result = sqlConnection.Query<TRes>(Sql, ObjParam, commandTimeout: 180,
                    commandType: CommandType.Text).ToList();
                conClose();
            }
            catch (Exception)
            {
                conClose();
            }

            return result;
        }
        //Sp ler Id output değeri dönmesini istedigmiz function
        public int SaveSpOutputEffectedCount<TReq>(string StoredProcedure, TReq ObjParam)
        {
            int OutPut = 0;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                DynamicParameters args = new DynamicParameters(ObjParam);//because of return paramater
                args.Add("ResId", 0, direction: ParameterDirection.Output);
                conOpen();
                int result = sqlConnection.Execute(StoredProcedure, args, commandTimeout: 180,
                    commandType: CommandType.StoredProcedure);

                OutPut = args.Get<int>("ResId");
                conClose();
            }
            catch (Exception ex)
            {
                conClose();
            }


            return OutPut;
        }

        public TRes GetQuery<TRes>(string Query)
        {
            TRes result = default;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                //var args = new DynamicParameters(ObjParam);
                conOpen();
                result = sqlConnection.Query<TRes>(Query, commandTimeout: 180,
                  commandType: CommandType.Text).FirstOrDefault();
                conClose();

            }
            catch (Exception ex)
            {

            }

            return result;


        }
        public IEnumerable<TRes> GetQueryList<TRes>(string Query)
        {
            IEnumerable<TRes> result = default;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                conOpen();
                result = sqlConnection.Query<TRes>(Query, commandTimeout: 180,
                  commandType: CommandType.Text).ToList();
                conClose();

            }
            catch (Exception ex)
            {

            }

            return result;


        }

    }
}
