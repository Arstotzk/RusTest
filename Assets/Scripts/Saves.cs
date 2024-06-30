using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saves : MonoBehaviour
{
    // Start is called before the first frame update
    public OpenResults openResults;
    public class OpenResults
    {
        string _resultString;
        public List<bool> results;

        public OpenResults(string resultString)
        {
            _resultString = resultString;
            results = new List<bool>();
            OpenString(resultString);
        }
        public void OpenString(string resultString)
        {
            foreach (var chr in resultString.ToCharArray())
            {
                if (chr == char.Parse("0"))
                {
                    results.Add(false);
                }
                else if (chr == char.Parse("1"))
                {
                    results.Add(true);
                }
            }
        }
        public void SaveResult(int number, bool result)
        {
            results[number - 1] = result;
        }
        public string GetStringResults() 
        {
            var stringResult = "";
            foreach (var result in results)
            {
                if (result == false)
                {
                    stringResult += "0";
                }
                else if (result == true)
                {
                    stringResult += "1";
                }
            }
            _resultString = stringResult;
            return stringResult;
        }
    }
    void Start()
    {
        var resultString = PlayerPrefs.GetString("OpenResults", "00000000000000000");
        openResults = new OpenResults(resultString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenResult(int resultId)
    {
        openResults.SaveResult(resultId, true);
        var stringResults = openResults.GetStringResults();
        PlayerPrefs.SetString("OpenResults", stringResults);
    }
}
