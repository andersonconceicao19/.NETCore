using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly DBContextMySQL _mySQL;
        private readonly DBContextSQLServer _sqlServer;

        public TesteController(DBContextMySQL mySQL, DBContextSQLServer sqlServer)
        {
            _mySQL = mySQL;
            _sqlServer = sqlServer;
        }

        [HttpGet("mysql")]
        public ActionResult GetMysql()
        {
            var users = _mySQL.Set<Usuario>().ToList();

            return Ok(users);
        }

        [HttpGet("sqlserver")]
        public ActionResult GetSql()
        {
            var users = _sqlServer.Set<Produto>().ToList();

            return Ok(users);
        }
    }
}
