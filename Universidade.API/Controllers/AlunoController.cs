using Universidade.Domain.Models;
using Universidade.Service.Interfaces;

namespace Universidade.API.Controllers
{
    public class AlunoController(IAlunoService service, ILogger<AlunoController> logger) : BaseController<Aluno>(service, logger)
    {
    }
}
