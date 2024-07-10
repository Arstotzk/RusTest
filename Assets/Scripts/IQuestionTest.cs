using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestionTest
{

    public void StartTest();
    public void GetAnswer(int value);
    public void NextQuestion();
}
