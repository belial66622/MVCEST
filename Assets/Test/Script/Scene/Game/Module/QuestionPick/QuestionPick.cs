using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MVCEST.Script.Tools
{
    public class QuestionPick
    {
        int level = 0;

        public QuestionPick(int levelSelected)
        {
            level = levelSelected;
        }
        

        public Question GetQuestion()
        {
          switch (level) 
            {
                case 1:
                    return new Question(Random.Range(1, 11), Random.Range(1, 11) , 0);
                case 2:
                    return new Question(Random.Range(1, 50), Random.Range(1, 100) , 0);
                case 3:
                    return new Question(Random.Range(1, 100), Random.Range(10, 500) , Random.Range(0,2));
            }
            return null;
        }
    }


    public class Question
    {
        public int firstNumber;
        public int secondNumber;
        public int operation;

        public Question(int a, int b , int c) 
        {
            firstNumber = a; secondNumber = b; operation = c;
        }
    }
}