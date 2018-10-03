﻿using BusinessLayer.Interfaces;
using BusinessLayer.Repositories;
using QuizWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace QuizWebApi.Controllers
{
    public class QuizController : ApiController
    {
        private IQuizRepository _quizRepository;
        private ICategoryRepository _categoryRepository;

        public QuizController()
        {
            _quizRepository = new QuizRepository();
            _categoryRepository = new CategoryRepository();
        }

        public List<QuizViewModel> GetAll()
        {
                return _quizRepository.GetAll().Select(t => new QuizViewModel
                {
                    QuizId = t.QuizId,
                    QuizTitle = t.QuizTitle,
                    Image_url = t.Image_url,
                    Difficulty = t.QuizDifficulty,
                    CategoryName = t.Category.CategoryName
                }).ToList();
        }

        public QuizViewModel Get(int id)
        {
            var mod = _quizRepository.GetByID(id);
            QuizViewModel model = new QuizViewModel();
            model.QuizId = mod.QuizId;
            model.QuizTitle = mod.QuizTitle;
            model.Image_url = mod.Image_url;
            model.Difficulty = mod.QuizDifficulty;
            model.CategoryName = mod.Category.CategoryName;
                return model;
        }
    }
}