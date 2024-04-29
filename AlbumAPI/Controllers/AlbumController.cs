using Microsoft.AspNetCore.Mvc;
using AlbumAPI.Models;
using AlbumAPI.Utilities;
using System.Text.Json;

namespace AlbumAPI.Controllers
{
    public class AlbumController : Controller
    {
        static int _RecordsPerPage { get; set; } = 10;
        private GenericPager<Album> _genericPager;

        private readonly HttpClient _httpClient;

        public AlbumController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> List(int page = 1)
        {
            try
            {
                HttpResponseMessage responseMessage = await _httpClient.GetAsync("");

                if (responseMessage.IsSuccessStatusCode)
                {
                    int _TotalRecords = 0;
                    int records = _RecordsPerPage;

                    string jsonResp = await responseMessage.Content.ReadAsStringAsync();
                    List<Album> pAlbum = JsonSerializer.Deserialize<List<Album>>(jsonResp);

                    _TotalRecords = pAlbum.Count;

                    var pagination = pAlbum.OrderBy(a => a.id).
                        Skip((page - 1) * _RecordsPerPage).
                        Take(_RecordsPerPage).
                        ToList();

                    var _TotalPages = (int)Math.Ceiling((double)_TotalRecords / _RecordsPerPage);

                    _genericPager = new GenericPager<Album>()
                    {
                        PerPage = records,
                        TotalRecords = _TotalRecords,
                        TotalPages = _TotalPages,
                        CurrentPage = page,
                        Result = pagination
                    };

                    return View(_genericPager);
                }
                else
                {
                    return View("Error");
                }
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRecordsPerPage(int RecordsPerPage)
        {
            _RecordsPerPage = RecordsPerPage;

            return RedirectToAction(nameof(List));
        }
    }
}
