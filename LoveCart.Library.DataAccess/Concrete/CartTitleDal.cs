using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LoveCart.Library.DataAccess.Abstract;
using LoveCart.Library.Entities.Models;
using LoveCart.Library.Utilities.Dto;
using Ragnarok.Library.Utilities.Extensions;

namespace LoveCart.Library.DataAccess.Concrete
{
    public class CartTitleDal: ICartTitleDal
    {

        private readonly IDbConnection _dbConnection;

        public CartTitleDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public Task<T> GetByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<int>> InsertAsync<T>(T t)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<int>> UpdateAsync<T>(T t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveRangeAsync<T>(IEnumerable<T> list)
        {
            throw new NotImplementedException();
        }

        public string LangCode { get; set; }
        public Task<BaseResponse<List<T>>> SelectAsync<T>(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<T>> FirstAsync<T>(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> ExistAsync<T>(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CartTitleDto>> GetAllAsync()
        {
            string sqlQuery = "sp_AllCartTitle";


         

            var result = await _dbConnection.QueryAsync<CartTitleDto>(
                sql: sqlQuery,
                commandType: CommandType.StoredProcedure);

            return result;
        }

        public async Task<CartTitleDto> GetCartTitleAsync(int Id)
        {
            string sqlQuery = "sp_GetCartTitleById";

            var p = new
            {
                Id = Id
            };

            var result = await _dbConnection.QuerySingleOrDefaultAsync<CartTitleDto>(
                sql: sqlQuery,
                param: p,
                commandType: CommandType.StoredProcedure);

            return result;
        }

        public async Task<IEnumerable<CartDetailDto>> GetCartDetailsByTitleIdAsync(int Id)
        {
            string sqlQuery = "sp_GetCartDetailsByTitleId";

            var p = new
            {
                Id = Id
            };

            var result = await _dbConnection.QueryAsync<CartDetailDto>(
                sql: sqlQuery,
                param: p,
                commandType: CommandType.StoredProcedure);

            return result;
        }


        public async Task<int> CreateCartDetailAsync(CartDetailDto Model)
        {

            return await _dbConnection.ExecuteAsync($"INSERT INTO [dbo].[CartDetail] ([Title],[Detail] ,[Images] ,[Date] ,[TitleId]) VALUES (@Title,@Detail,@Images,@Date,@TitleId) ", Model);

           


        }
    }
}
