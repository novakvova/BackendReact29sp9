using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Backend.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class GameController : ApiController
    {
        // GET: Game
        public IHttpActionResult GetAllGames()
        {
            var model = new List<GameItemViewModel>
            {
                new GameItemViewModel
                {
                    id=1,
                    title="GTA 5",
                    image="https://torrent-igruha.org/uploads/posts/2015-02/1424891927_grand_theft_auto_v_gta_5-16989099-frntl.jpg"
                },
                new GameItemViewModel
                {
                    id=2,
                    title="DOTA 2",
                    image="https://static-cdn.jtvnw.net/ttv-boxart/Dota%202.jpg"
                }
            };

            return Content(HttpStatusCode.OK, model);
        }
    }
}