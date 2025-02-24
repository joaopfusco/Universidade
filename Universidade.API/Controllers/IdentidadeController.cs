using Universidade.Domain.Models;
using Universidade.Service.Interfaces;

namespace Universidade.API.Controllers
{
    public class IdentidadeController(IIdentidadeService service, ILogger<IdentidadeController> logger) : BaseController<Identidade>(service, logger)
    {
    }
}
