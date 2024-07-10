using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class QuestionTestKnow : MonoBehaviour, IQuestionTest
{
    public MainMenu mainMenu;
    public Result result;
    public List<QuestionKnow> questions;
    public QuestionKnow currentQuestion;
    public int questionId = 0;

    public TMP_Text questionTextUI;
    public TMP_Text questionNumUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartTest()
    {
        questionId = 0;
        currentQuestion = questions[questionId];
        questionTextUI.text = currentQuestion.text;
        questionNumUI.text = (questionId + 1).ToString() + "/" + questions.Count;
        result.rus = 0;
        result.heroism = 0;
    }
    public void GetAnswer(int value)
    {
        if (currentQuestion.isRus)
        {
            result.rus += value;
        }

        NextQuestion();
    }

    public void NextQuestion()
    {
        questionId += 1;
        if (questions.Count <= questionId)
        {
            mainMenu.ShowPreResult();
        }
        else
        {
            currentQuestion = questions[questionId];
            questionTextUI.text = currentQuestion.text;
            questionNumUI.text = (questionId + 1).ToString() + "/" + questions.Count;
        }
    }
}
