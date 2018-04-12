using System.Linq;
using ASPdotNetWebApiTestTask.Models;
using System.Web.Mvc;

namespace ASPdotNetWebApiTestTask.Controllers {
    public class WordsOrPhrasesController : Controller {
        WordContext db = new WordContext();

        public ActionResult ApiTables() {
            // Использовать одноименное с именем метода (ApiTables) представление
            // и передать представлению объекты модели.
            return View(db.WordsOrPhrases.ToList());
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
