using Microsoft.AspNetCore.Mvc;
using webmvc.Models;

namespace webmvc.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public AnalysisResult[] Get()
        {
            return new[]
            {
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cancer de Pulmon",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cáncer de Colon",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cáncer de Laringe",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cáncer de Hueso",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cancer de Vejiga",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Linfoma de Hodgkin",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Gota",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Epilepsia",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Glaucoma",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Rinitis Alergica",RelativeRisk = "6,07%",Level = "Bajo"},
                new AnalysisResult{Customer = "Pepe Perez",HealthProblem = "Cáncer de Higado",RelativeRisk = "6,07%",Level = "Bajo"}
            };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
