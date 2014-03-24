using System.Collections.Generic;
using System.Web.Http;
using Wardrobe.Models;

namespace Wardrobe.Controllers
{
    public class WardRobeController : ApiController
    {
        WardRobe wardRobe = new WardRobe();
        // GET api/values
        public IEnumerable<ClothingItem> GetAll()
        {
            return wardRobe.GetAllClothingItems();
        }

        // GET api/values/5
        public ClothingItem Get(int id)
        {
            return wardRobe.GetClothing(id);
        }

        // GET api/values/5
        public IEnumerable<ClothingItem> GetWardRobeByWeather(Weather weather)
        {
            return wardRobe.GetClothingFor(weather);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }
}