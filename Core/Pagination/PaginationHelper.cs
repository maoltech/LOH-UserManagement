using Microsoft.EntityFrameworkCore;

namespace LOH_UserManagement.Core.Pagination
{
    public class PaginationHelper
    {
        public async Task<PaginationResult<T>> PaginateAsync<T>(
            IQueryable<T> queryable,
            int pageNumber,
            int pageSize)
        {
            var count = await queryable.CountAsync();
            var items = await queryable
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginationResult<T>
            {
                Items = items,
                TotalCount = count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }

    public class PaginationResult<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

}
