using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Web.Http;
using ASPdotNetWebApiTestTask.Models;
using System.Web.Http.Description;
using System.Data.Entity.Infrastructure;

namespace ASPdotNetWebApiTestTask.Controllers {
    public class WordOrPhraseChangingController : ApiController {
        private WordContext db = new WordContext();

        public IHttpActionResult PutWordOrPhrase(int id, [FromBody]WordOrPhrase editedWordOrPhrase) {
            if (editedWordOrPhrase.Id != id) {
                return BadRequest();
            }
            db.Entry(editedWordOrPhrase).State = EntityState.Modified;
            try {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException) {
                if (!WordOrPhraseExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool WordOrPhraseExists(int id) {
            return db.WordsOrPhrases.Count(e => e.Id == id) > 0;
        }
    }
}
