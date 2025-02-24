using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Universidade.Service.Interfaces;
using Universidade.Domain.Models;
using Universidade.Infra.Data;

namespace Universidade.Service.Services
{
    public class AlunoService(AppDbContext db) : BaseService<Aluno>(db), IAlunoService
    {
        
    }
}
