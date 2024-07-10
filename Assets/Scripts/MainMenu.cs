using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject questionMenu;
    public GameObject resultMenu;
    public GameObject settingsMenu;
    public GameObject preResult;
    public GameObject resultUI;
    public GameObject questionMenuKnow;

    public QuestionTest questionTest;
    public QuestionTestKnow questionTestKnow;
    public Result result;
    public Settings settings;
    public SetOpenResults setOpenResults;

    private bool isKnowTest = false;
    public void Start()
    {
        settings.SetMusicValue();
    }
    public void StartTest()
    {
        mainMenu.SetActive(false);
        questionMenu.SetActive(true);
        //заполн€ем вопросы
        questionTest.StartTest();
        isKnowTest = false;
    }

    public void StartTestKnow()
    {
        mainMenu.SetActive(false);
        questionMenuKnow.SetActive(true);
        //заполн€ем вопросы
        questionTestKnow.StartTest();
        isKnowTest = true;
    }
    public void EndTest()
    {
        mainMenu.SetActive(true);
        resultUI.SetActive(false);
    }
    public void ShowResults()
    {
        //ѕроверка что хоть один раз тест прошли
        setOpenResults.SetResults();
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
        settings.SaveMusicValue();
    }
    public void ShowPreResult()
    {
        questionMenu.SetActive(false);
        questionMenuKnow.SetActive(false);
        preResult.SetActive(true);
        //–еклама
        YandexGame.FullscreenShow();
    }
    public void ShowResult()
    {
        if (isKnowTest)
            result.SetVariantKnow();
        else
            result.SetVariant();
        preResult.SetActive(false);
        resultUI.SetActive(true);
    }
    public void ShowResult(int variantId)
    {
        result.SetVariant(variantId);
        resultMenu.SetActive(false);
        resultUI.SetActive(true);
    }
}
