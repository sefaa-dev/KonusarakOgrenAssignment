using System;
using System.ComponentModel.DataAnnotations;

namespace EnglishQuestionApp.Models.Abstracts

{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(128)]
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [StringLength(128)]
        public string UpdatedUser { get; set; }
    }
}
