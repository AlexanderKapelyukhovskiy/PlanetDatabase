using System.Net;
using System.Net.Http;
using Moq;
using NUnit.Framework;
using PlanetDatabase.Common;
using PlanetDatabase.Web.ApiControllers;

namespace PlanetDatabase.Tests
{
    [TestFixture]
    public class PlanetsControllerTests
    {
        [Test]
        public void should_return_not_found_when_not_existing_id_requested_test()
        {
            var repositoryMock = new Mock<IPlanetsRepository>();

            var controller = new PlanetsController(repositoryMock.Object) {Request = new HttpRequestMessage()};

            HttpResponseMessage response = controller.Get(1);
            Assert.That(response, Is.Not.Null);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }
    }
}