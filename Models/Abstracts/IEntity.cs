﻿namespace EnglishQuestionApp.Models.Abstracts
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}