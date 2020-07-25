using IQTest.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IQTest.Data.Helpers
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var questionId = 1;
            var optionId = 1;

            modelBuilder.Entity<User>().HasData(
                HashHelper.CreateDefaulAdminUserObject()
            );

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 1,
                    ImagePath = "Resources/QuestionImages/q1.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 1,
                    ImagePath = "Resources/QuestionImages/q2.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 1,
                    ImagePath = "Resources/QuestionImages/q3.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 1,
                    ImagePath = "Resources/QuestionImages/q4.png",
                    Options = new List<Option>()
                }, 
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 2,
                    ImagePath = "Resources/QuestionImages/q5.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 2,
                    ImagePath = "Resources/QuestionImages/q6.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 2,
                    ImagePath = "Resources/QuestionImages/q7.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 2,
                    ImagePath = "Resources/QuestionImages/q8.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 3,
                    ImagePath = "Resources/QuestionImages/q9.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 3,
                    ImagePath = "Resources/QuestionImages/q10.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 3,
                    ImagePath = "Resources/QuestionImages/q11.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 3,
                    ImagePath = "Resources/QuestionImages/q12.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 4,
                    ImagePath = "Resources/QuestionImages/q13.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 4,
                    ImagePath = "Resources/QuestionImages/q14.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 4,
                    ImagePath = "Resources/QuestionImages/q15.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 4,
                    ImagePath = "Resources/QuestionImages/q16.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 5,
                    ImagePath = "Resources/QuestionImages/q17.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 5,
                    ImagePath = "Resources/QuestionImages/q18.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 5,
                    ImagePath = "Resources/QuestionImages/q19.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 5,
                    ImagePath = "Resources/QuestionImages/q20.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 6,
                    ImagePath = "Resources/QuestionImages/q21.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 6,
                    ImagePath = "Resources/QuestionImages/q22.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 6,
                    ImagePath = "Resources/QuestionImages/q23.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 6,
                    ImagePath = "Resources/QuestionImages/q24.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 7,
                    ImagePath = "Resources/QuestionImages/q25.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 7,
                    ImagePath = "Resources/QuestionImages/q26.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 7,
                    ImagePath = "Resources/QuestionImages/q27.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 7,
                    ImagePath = "Resources/QuestionImages/q28.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 8,
                    ImagePath = "Resources/QuestionImages/q29.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 8,
                    ImagePath = "Resources/QuestionImages/q30.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 8,
                    ImagePath = "Resources/QuestionImages/q31.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 8,
                    ImagePath = "Resources/QuestionImages/q32.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 9,
                    ImagePath = "Resources/QuestionImages/q33.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 9,
                    ImagePath = "Resources/QuestionImages/q34.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 9,
                    ImagePath = "Resources/QuestionImages/q35.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 9,
                    ImagePath = "Resources/QuestionImages/q36.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 10,
                    ImagePath = "Resources/QuestionImages/q37.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 10,
                    ImagePath = "Resources/QuestionImages/q38.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 10,
                    ImagePath = "Resources/QuestionImages/q39.png",
                    Options = new List<Option>()
                },
                new Question
                {
                    Id = questionId++,
                    Name = "Choose the missing figure.",
                    Difficulty = 10,
                    ImagePath = "Resources/QuestionImages/q40.png",
                    Options = new List<Option>()
                }
            );

            modelBuilder.Entity<Option>().HasData(
                // OPTIONS FOR QUESTION 1
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q1o1.png",
                    QuestionId = 1
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q1o2.png",
                    QuestionId = 1
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q1o3.png",
                    QuestionId = 1
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q1o4.png",
                    QuestionId = 1
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q1o5.png",
                    QuestionId = 1
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q1o6.png",
                    QuestionId = 1
                },
                // OPTIONS FOR QUESTION 2
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q2o1.png",
                    QuestionId = 2
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q2o2.png",
                    QuestionId = 2
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q2o3.png",
                    QuestionId = 2
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q2o4.png",
                    QuestionId = 2
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q2o5.png",
                    QuestionId = 2
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q2o6.png",
                    QuestionId = 2
                },
                // OPTIONS FOR QUESTION 3
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q3o1.png",
                    QuestionId = 3
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q3o2.png",
                    QuestionId = 3
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q3o3.png",
                    QuestionId = 3
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q3o4.png",
                    QuestionId = 3
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q3o5.png",
                    QuestionId = 3
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q3o6.png",
                    QuestionId = 3
                },
                // OPTIONS FOR QUESTION 4
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q4o1.png",
                    QuestionId = 4
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q4o2.png",
                    QuestionId = 4
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q4o3.png",
                    QuestionId = 4
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q4o4.png",
                    QuestionId = 4
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q4o5.png",
                    QuestionId = 4
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q4o6.png",
                    QuestionId = 4
                },
                // OPTIONS FOR QUESTION 5
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q5o1.png",
                    QuestionId = 5
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q5o2.png",
                    QuestionId = 5
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q5o3.png",
                    QuestionId = 5
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q5o4.png",
                    QuestionId = 5
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q5o5.png",
                    QuestionId = 5
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q5o6.png",
                    QuestionId = 5
                },
                // OPTIONS FOR QUESTION 6 --- TODO: CORRECT ANSWERS
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q6o1.png",
                    QuestionId = 6
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q6o2.png",
                    QuestionId = 6
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q6o3.png",
                    QuestionId = 6
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q6o4.png",
                    QuestionId = 6
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q6o5.png",
                    QuestionId = 6
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q6o6.png",
                    QuestionId = 6
                },
                // OPTIONS FOR QUESTION 7
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q7o1.png",
                    QuestionId = 7
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q7o2.png",
                    QuestionId = 7
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q7o3.png",
                    QuestionId = 7
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q7o4.png",
                    QuestionId = 7
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q7o5.png",
                    QuestionId = 7
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q7o6.png",
                    QuestionId = 7
                },
                // OPTIONS FOR QUESTIONS 8
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q8o1.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q8o2.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q8o3.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q8o4.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q8o5.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q8o6.png",
                    QuestionId = 8
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q9o1.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q9o2.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q9o3.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q9o4.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q9o5.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q9o6.png",
                    QuestionId = 9
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q10o1.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q10o2.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q10o3.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q10o4.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q10o5.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q10o6.png",
                    QuestionId = 10
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q11o1.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q11o2.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q11o3.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q11o4.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q11o5.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q11o6.png",
                    QuestionId = 11
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q12o1.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q12o2.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q12o3.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q12o4.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q12o5.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q12o6.png",
                    QuestionId = 12
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q13o1.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q13o2.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q13o3.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q13o4.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q13o5.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q13o6.png",
                    QuestionId = 13
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q14o1.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q14o2.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q14o3.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q14o4.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q14o5.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q14o6.png",
                    QuestionId = 14
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q15o1.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q15o2.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q15o3.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q15o4.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q15o5.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q15o6.png",
                    QuestionId = 15
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q16o1.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q16o2.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q16o3.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q16o4.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q16o5.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q16o6.png",
                    QuestionId = 16
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q17o1.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q17o2.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q17o3.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q17o4.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q17o5.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q17o6.png",
                    QuestionId = 17
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q18o1.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q18o2.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q18o3.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q18o4.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q18o5.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q18o6.png",
                    QuestionId = 18
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q19o1.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q19o2.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q19o3.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q19o4.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q19o5.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q19o6.png",
                    QuestionId = 19
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q20o1.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q20o2.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q20o3.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q20o4.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q20o5.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q20o6.png",
                    QuestionId = 20
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q21o1.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q21o2.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q21o3.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q21o4.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q21o5.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q21o6.png",
                    QuestionId = 21
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q22o1.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q22o2.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q22o3.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q22o4.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q22o5.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q22o6.png",
                    QuestionId = 22
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q23o1.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q23o2.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q23o3.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q23o4.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q23o5.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q23o6.png",
                    QuestionId = 23
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q24o1.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q24o2.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q24o3.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q24o4.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q24o5.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q24o6.png",
                    QuestionId = 24
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q25o1.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q25o2.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q25o3.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q25o4.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q25o5.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q25o6.png",
                    QuestionId = 25
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q26o1.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q26o2.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q26o3.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q26o4.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q26o5.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q26o6.png",
                    QuestionId = 26
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q27o1.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q27o2.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q27o3.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q27o4.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q27o5.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q27o6.png",
                    QuestionId = 27
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q28o1.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q28o2.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q28o3.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q28o4.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q28o5.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q28o6.png",
                    QuestionId = 28
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q29o1.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q29o2.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q29o3.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q29o4.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q29o5.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q29o6.png",
                    QuestionId = 29
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q30o1.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q30o2.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q30o3.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q30o4.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q30o5.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q30o6.png",
                    QuestionId = 30
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q31o1.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q31o2.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q31o3.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q31o4.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q31o5.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q31o6.png",
                    QuestionId = 31
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q32o1.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q32o2.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q32o3.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q32o4.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q32o5.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q32o6.png",
                    QuestionId = 32
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q33o1.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q33o2.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q33o3.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q33o4.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q33o5.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q33o6.png",
                    QuestionId = 33
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q34o1.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q34o2.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q34o3.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q34o4.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q34o5.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q34o6.png",
                    QuestionId = 34
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q35o1.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q35o2.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q35o3.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q35o4.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q35o5.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q35o6.png",
                    QuestionId = 35
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q36o1.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q36o2.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q36o3.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q36o4.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q36o5.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q36o6.png",
                    QuestionId = 36
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q37o1.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q37o2.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q37o3.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q37o4.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q37o5.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q37o6.png",
                    QuestionId = 37
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q38o1.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q38o2.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q38o3.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q38o4.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q38o5.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q38o6.png",
                    QuestionId = 38
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q39o1.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q39o2.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q39o3.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q39o4.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q39o5.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q39o6.png",
                    QuestionId = 39
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q40o1.png",
                    QuestionId = 40
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q40o2.png",
                    QuestionId = 40
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q40o3.png",
                    QuestionId = 40
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q40o4.png",
                    QuestionId = 40
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = false,
                    ImagePath = "Resources/QuestionOptionImages/q40o5.png",
                    QuestionId = 40
                },
                new Option
                {
                    Id = optionId++,
                    IsAnswer = true,
                    ImagePath = "Resources/QuestionOptionImages/q40o6.png",
                    QuestionId = 40
                }
            );
        }
    }
}
