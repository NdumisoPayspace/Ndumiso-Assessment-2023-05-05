namespace Ndumiso_Assessment_2023_05_05.APIControllers
{
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;

    using Microsoft.AspNetCore.Mvc;

    using Ndumiso_Assessment_2023_05_05.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class PeopleAPIController : ControllerBase
    {
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(MockData.people.ToList(), loadOptions);
        }
    }
}
