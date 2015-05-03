using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlanetDatabase.Common;
using PlanetDatabase.Common.Entities;

namespace PlanetDatabase.Web.ApiControllers
{
    public class PlanetsController : ApiController
    {
        private readonly IPlanetsRepository _repository;

        public PlanetsController(IPlanetsRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
        }

        public HttpResponseMessage Get()
        {
            var planets = _repository.GetAllPlanets().Select(p => new {id = p.Id, name = p.Name}).ToArray();

            return Request.CreateResponse(HttpStatusCode.OK, planets);
        }

        public HttpResponseMessage Get(int id)
        {
            Planet planet = _repository.GetById(id);
            if (planet == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);

            return Request.CreateResponse(HttpStatusCode.OK,
                new {id = planet.Id, name = planet.Name, distance = planet.DistanceToSolar});
        }
    }
}