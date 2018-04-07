using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASPdotNetWebApiTestTask.Models;

namespace ASPdotNetWebApiTestTask.Models {
    /// <summary>
    /// Для автоматического заполнения БД несколькими записями.
    /// </summary>
    public class DbInitializer : DropCreateDatabaseAlways<WordContext> {
        protected override void Seed(WordContext db) {
            db.WordsOrPhrases.Add(new WordOrPhrase { Text = "human", LearningStage = 2, MainTranslation = "человек", PhTranscription = "['hjuːmən]", WhenAdded = DateTime.UtcNow });
            db.WordsOrPhrases.Add(new WordOrPhrase { Text = "winter", LearningStage = 0, MainTranslation = "зима", PhTranscription = "['wɪntə]", WhenAdded = DateTime.UtcNow });
            db.WordsOrPhrases.Add(new WordOrPhrase { Text = "home", LearningStage = 3, MainTranslation = "дом", PhTranscription = "[həum]", WhenAdded = DateTime.UtcNow });
            db.WordsOrPhrases.Add(new WordOrPhrase { Text = "learn", IsIrregularVerb = true, LearningStage = 1, MainTranslation = "учиться", PhTranscription = "[lɜːn]", WhenAdded = DateTime.UtcNow });
            db.WordsOrPhrases.Add(new WordOrPhrase { Text = "cannot / can't help something", LearningStage = 1, MainTranslation = "не в силах удержаться от чего-либо", WhenAdded = DateTime.UtcNow });
            base.Seed(db);
        }
    }
}