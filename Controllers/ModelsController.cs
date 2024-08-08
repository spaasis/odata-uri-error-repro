using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace odata_repro.Controllers;

public class ModelsController : ODataController
{
    [EnableQuery]
    public ActionResult<IEnumerable<Model>> Get()
    {
        var models = new List<Model>()
        {
            new() { Id = "Id1", Value = "Value1" }
        };
        return Ok(models);
    }
}