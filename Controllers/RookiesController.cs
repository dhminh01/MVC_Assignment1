using Microsoft.AspNetCore.Mvc;
using MVC_Assignment1.Models;
using MVC_Assignment1.Services;
using OfficeOpenXml;

namespace MVC_Assignment1.Controllers
{
    [Route("NashTech/[controller]/[action]")]
    public class RookiesController : Controller
    {
        private readonly IPersonService _personService;
        public RookiesController(IPersonService personService)
        {
            _personService = personService;
        }

        //NashTech/Rookies/GetAll
        [HttpGet]
        public IActionResult GetAll()
        {
            var people = _personService.GetAll();

            return Ok(people);
        }

        //NashTech/Rookies/GetMales
        [HttpGet]
        public IActionResult GetMale()
        {
            var people = _personService.GetMales();

            return Ok(people);
        }

        //NashTech/Rookies/GetOldest
        [HttpGet]
        public IActionResult GetOldest()
        {
            var oldest = _personService.GetOldest();

            return Ok(oldest);
        }

        //NashTech/Rookies/GetFullNames
        [HttpGet]
        public IActionResult GetFullNames()
        {
            var fullNames = _personService.GetFullNames();

            return Ok(fullNames);
        }

        //NashTech/Rookies/FilterByBirthYear?condition=equal
        //NashTech/Rookies/FilterByBirthYear?condition=greater
        //NashTech/Rookies/FilterByBirthYear?condition=less
        [HttpGet]
        public IActionResult FilterByBirthYear(string condition)
        {
            var result = _personService.FilterByBirthYear(condition);

            return Ok(result);
        }

        [HttpGet]
        public IActionResult ExportToExcel()
        {
            var people = _personService.GetAll();
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("People");
            worksheet.Cells.LoadFromCollection(people, true);
            int dateColumnIndex = 6;
            for (int row = 2; row <= people.Count + 1; row++)
            {
                worksheet.Cells[row, dateColumnIndex].Style.Numberformat.Format = "yyyy-mm-dd";
            }
            var stream = new MemoryStream(package.GetAsByteArray());

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "People.xlsx");
        }
    }
}
