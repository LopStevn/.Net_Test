using System.Runtime.ConstrainedExecution;

namespace AlbumAPI.Utilities
{
    public class GenericPager<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int PerPage { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<T> Result { get; set; }
    }
}
