using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionTest : MonoBehaviour
{
    public MainMenu mainMenu;
    public Result result;
    public List<Question> questions;
    public Question currentQuestion;
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
        questionNumUI.text = (questionId + 1).ToString() + "/16";
        result.rus = 0;
        result.heroism = 0;
    }
    public void GetAnswer(int value)
    {
        if (currentQuestion.isRus)
        {
            if (!currentQuestion.isRevert)
                result.rus += value;
            else
                result.rus -= value;
        }
        else if (currentQuestion.isHeroism)
        {
            if (!currentQuestion.isRevert)
                result.heroism += value;
            else
                result.heroism -= value;
        }
        NextQuestion();
    }

    private void NextQuestion() 
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
            questionNumUI.text = (questionId + 1).ToString() + "/16";
        }
    } 
}
