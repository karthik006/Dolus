using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CronusMaster : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
        backButton.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenJournal1()
    {
        text.enabled = true;
        text.text = "";
        backButton.SetActive(true);
        string path = "Assets/Data/Journal1.txt";
        StreamReader streamReader = new StreamReader(path);

        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            text.text += line;
        }

        streamReader.Close();
    }
}
