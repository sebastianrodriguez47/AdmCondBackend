using Microsoft.EntityFrameworkCore;

namespace AdmCondominioBack.Data
{
    public class Pagination<T> : List<T>
    {
        public int InitialPage { get; private set; }
        public int PageSize { get; private set; }

        public Pagination(List <T> items, int counter, int initialPage, int totalResults)
        {
            InitialPage = initialPage;
            PageSize = (int)Math.Ceiling(counter /(double) totalResults);

            this.AddRange(items);
        }

        public bool PreviousPages => InitialPage > 1;

        public bool NextPages => InitialPage < PageSize;

        public static async Task<Pagination<T>> BuildPagination(IQueryable<T> source, int initialPage, int totalResults)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((initialPage-1) * totalResults).Take(totalResults).ToListAsync();

            return new Pagination<T>(items, count, initialPage, totalResults);
        }
    }
}
