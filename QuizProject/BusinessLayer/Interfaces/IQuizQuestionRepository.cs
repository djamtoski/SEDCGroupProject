﻿using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IQuizQuestionRepository
    {
        IQueryable<QuizQuestion> GetAll();
        QuizQuestion GetByID(int ID);
        void Insert(QuizQuestion quizQuestion);
        void Update(QuizQuestion quizQuestion);
        void Delete(QuizQuestion quizQuestion);
        void Delete(int quizQuestionId);
        bool Exists(int quizQuestionId);
    }
}
