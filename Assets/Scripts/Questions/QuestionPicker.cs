using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class QuestionPicker
{
    public Question GetRandomQuestion()
    {
        List<String> Operators = new List<String> { "*", "/" };
        Question q = new Question { 
                                    number1 = UnityEngine.Random.Range(1, 50), 
                                    number2 = UnityEngine.Random.Range(1, 10), 
                                    op = Operators[UnityEngine.Random.Range(0, Operators.Count)] 
                                  };

        if (q.op == "/")
        {
            // number2 must always be less or equal than number 1
            // The division between number1 and number 2 must give mod 0
            while(q.number2 > q.number1 || q.number1 % q.number2 != 0)
                q.number2 = UnityEngine.Random.Range(1, 10);
        }

        // Calculate the result using the randomly picked operator
        int result;
        if (q.op == "*") 
            result = q.number1 * q.number2;
        else 
            result = q.number1 / q.number2;

        // Place correct answer into random order
        int answerPosition = UnityEngine.Random.Range(1, 3);
        if (answerPosition == 1) 
        {
            q.answer1 = result;
            q.answer2 = result + 10;
            q.answer3 = result - 3;
        } 
        else if (answerPosition == 2) 
        {
            q.answer1 = result + 10;
            q.answer2 = result;
            q.answer3 = result - 3;
        }
        else 
        {
            q.answer1 = result - 3;
            q.answer2 = result + 10;
            q.answer3 = result;
        }

        return q;
    }
}


[Serializable]
public class Question
{
    // 5 + 10 = ?
    public int number1;
    public string op;
    public int number2;

    // Give 3 possible answers
    public int answer1;
    public int answer2;
    public int answer3;
}