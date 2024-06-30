using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject questionMenu;
    public GameObject resultMenu;
    public GameObject settingsMenu;
    public GameObject preResult;
    public GameObject resultUI;

    public QuestionTest questionTest;
    public Result result;
    public void StartTest()
    {
        mainMenu.SetActive(false);
        questionMenu.SetActive(true);
        //��������� �������
        questionTest.StartTest();
    }
    public void EndTest()
    {
        mainMenu.SetActive(true);
        resultUI.SetActive(false);
    }
    public void ShowResults()
    {
        //�������� ��� ���� ���� ��� ���� ������
        mainMenu.SetActive(false);
        resultMenu.SetActive(true);
    }
    public void UnshowResults()
    {
        mainMenu.SetActive(true);
        resultMenu.SetActive(false);
    }
    public void ShowSettings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void UnshowSettings()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void ShowPreResult()
    {
        questionMenu.SetActive(false);
        preResult.SetActive(true);
        //�������
    }
    public void ShowResult()
    {
        result.SetVariant();
        preResult.SetActive(false);
        resultUI.SetActive(true);
    }
}
