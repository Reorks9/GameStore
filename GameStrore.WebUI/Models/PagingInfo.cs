using System;

namespace GameStore.WebUI.Models
{
    public class PagingInfo
    {
        // Totul count products
        public int TotalItems { get; set; }

        // Count products on page
        public int ItemsPerPage { get; set; }

        // Numver cyrrent page
        public int CurrentPage { get; set; }

        // Total count pages
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}