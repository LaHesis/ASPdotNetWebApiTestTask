//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPdotNetWebApiTestTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WordOrPhrase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WordOrPhrase()
        {
            this.PhTranscription = "[...]";
            this.IsIrregularVerb = false;
            this.LearningStage = 0;
        }
    
        public int Id { get; set; }
        public string Text { get; set; }
        public string MainTranslation { get; set; }
        public string PhTranscription { get; set; }
        public bool IsIrregularVerb { get; set; }
        public System.DateTime WhenAdded { get; set; }
        public byte LearningStage { get; set; }
    }
}
