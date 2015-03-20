using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videos.Models;

namespace Videos.Controllers
{
    public class VideosController : ApiController
    {
        private VideoDb db;
        
        public VideosController()
        {
            db = new VideoDb();
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/videoapi
        public IEnumerable<Video> GetAllVideos()
        {
            var videos = db.Videos;
            return videos;
        }

        // GET api/videoapi
        public IEnumerable<Video> GetAllVideo(int x)
        {
            var videos = db.Videos;
            return videos;
        }

        // GET api/videoapi/5
        public Video Get(int id)
        {
            var video = db.Videos.Find(id);
            if (video == null)
            {
                //Request.CreateErrorResponse(HttpStatusCode.NotFound);
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return video;
        }

        // POST api/videoapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/videoapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/videoapi/5
        public void Delete(int id)
        {
        }
    }
}
