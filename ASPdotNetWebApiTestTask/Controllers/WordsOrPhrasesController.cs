using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASPdotNetWebApiTestTask.Models;
using System.Data;
using System.Web.Mvc;

namespace ASPdotNetWebApiTestTask.Controllers {
    public class WordsOrPhrasesController : Controller {
        WordContext db = new WordContext();

        public ActionResult ApiTables() {
            // Использовать одноименное с именем метода (ApiTables) представление
            // и передать представлению объекты модели.
            return View(db.WordsOrPhrases.ToList());
        }

        //[HttpPost]
        public void CreateWordOrPhrase([FromBody]WordOrPhrase wrdOrPhrs) {
            db.WordsOrPhrases.Add(wrdOrPhrs);
            db.SaveChanges();
        }

        //[HttpPut]
        public void EditWordOrPhrase(int id, [FromBody]WordOrPhrase wrdOrPhrs) {
            if (id == wrdOrPhrs.Id) {
                db.Entry(wrdOrPhrs).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        
        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
