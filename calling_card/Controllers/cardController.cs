using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calling_card.Controllers{
    public class CardController : Controller{
        [HttpGet]
        [Route("")]
        public JsonResult DisplayCard(){
            var cardObject = new
            {
                firstName = "Shawn",
                lastName = "Baugh",
                age = 25,
                favoriteColor = "Aqua/Teal"
            };
            return Json(cardObject);
        }
    }
}