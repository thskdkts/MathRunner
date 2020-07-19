using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class QuestionPicker
{
    public List<Question> Questions;

    public QuestionPicker()
    {
        Questions = new List<Question>
        {
            new Question
            {
                id = 1,
                number1 = 10,
                number2 = 5,
                op = "+",
                answer1 = 15,
                answer2 = 14,
                answer3 = 16
            },
            new Question
            {
                id = 2,
                number1 = 9,
                number2 = 4,
                op = "-",
                answer1 = 3,
                answer2 = 6,
                answer3 = 5
            },
            new Question
            {
                id = 3,
                number1 = 6,
                number2 = 2,
                op = "*",
                answer1 = 10,
                answer2 = 14,
                answer3 = 12
            },
            new Question
            {
                id = 4,
                number1 = 10,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 4
            },
             new Question
            {
                id = 5,
                number1 = 10,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 4
            },
              new Question
            {
                id = 6,
                number1 = 10,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 4
            },
               new Question
            {
                id = 7,
                number1 = 20,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 4
            },
                new Question
            {
                id = 8,
                number1 = 30,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 6
            },
                 new Question
            {
                id = 9,
                number1 = 50,
                number2 = 5,
                op = "/",
                answer1 = 3,
                answer2 = 10,
                answer3 = 4
            },
                  new Question
            {
                id = 10,
                number1 = 7,
                number2 = 7,
                op = "/",
                answer1 = 3,
                answer2 = 1,
                answer3 = 4
            },
                   new Question
            {
                id = 11,
                number1 = 42,
                number2 = 7,
                op = "/",
                answer1 = 3,
                answer2 = 2,
                answer3 = 6
            },
                    new Question
            {
                id = 12,
                number1 = 100,
                number2 = 20,
                op = "/",
                answer1 = 5,
                answer2 = 2,
                answer3 = 4
            },
                     new Question
            {
                id = 13,
                number1 = 81,
                number2 = 9,
                op = "/",
                answer1 = 3,
                answer2 = 9,
                answer3 = 4
            },
                      new Question
            {
                id = 14,
                number1 = 25,
                number2 = 5,
                op = "/",
                answer1 = 5,
                answer2 = 2,
                answer3 = 4
            },
                       new Question
            {
                id = 15,
                number1 = 100,
                number2 = 2,
                op = "/",
                answer1 = 50,
                answer2 = 60,
                answer3 = 40
            },


        };

    }

    public Question GetRandomQuestion()
    {
        return Questions[UnityEngine.Random.Range(0, Questions.Count)];
    }
}


[Serializable]
public class Question
{
    // Put some id
    public int id;

    // 5 + 10 = ?
    public int number1;
    public string op;
    public int number2;

    // Give 3 possible answers
    public int answer1;
    public int answer2;
    public int answer3;
}