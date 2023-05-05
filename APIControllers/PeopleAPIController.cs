namespace Ndumiso_Assessment_2023_05_05.APIControllers
{
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;

    using Microsoft.AspNetCore.Mvc;

    using Ndumiso_Assessment_2023_05_05.Models;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    public class PeopleAPIController : Controller
    {
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(MockData.people.ToList(), loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newPerson = new Person();

            JsonConvert.PopulateObject(values, newPerson);

            MockData.people.Add(newPerson);

            return this.Ok(newPerson);
        }
    }
}
