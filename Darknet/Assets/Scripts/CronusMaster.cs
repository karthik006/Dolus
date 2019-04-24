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
    [SerializeField]
    GameObject Journal1;
    [SerializeField]
    GameObject Journal2;
    [SerializeField]
    GameObject Journal3;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
        backButton.SetActive(false);
        Journal1.SetActive(true);
        Journal2.SetActive(true);
        Journal3.SetActive(true);
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
        Journal1.SetActive(false);
        Journal2.SetActive(false);
        Journal3.SetActive(false);
        string path = "Assets/Data/Journal1.txt";
        StreamReader streamReader = new StreamReader(path);

        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            text.text += line;
        }

        streamReader.Close();
    }

    public void OpenJournal2()
    {
        if (HomeMaster.stage == "B")
        {
            text.enabled = true;
            text.text = "";
            backButton.SetActive(true);
            Journal1.SetActive(false);
            Journal2.SetActive(false);
            Journal3.SetActive(false);
            string path = "Assets/Data/Journal2.txt";
            StreamReader streamReader = new StreamReader(path);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                text.text += line;
            }

            streamReader.Close();
        }
    }

    public void OpenJournal3()
    {
        if (HomeMaster.stage == "C")
        {
            text.enabled = true;
            text.text = "";
            backButton.SetActive(true);
            Journal1.SetActive(false);
            Journal2.SetActive(false);
            Journal3.SetActive(false);
            string path = "Assets/Data/Journal3.txt";
            StreamReader streamReader = new StreamReader(path);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                text.text += line;
            }

            streamReader.Close();
        }
    }

    public void Back()
    {
        text.enabled = false;
        backButton.SetActive(false);
        Journal1.SetActive(true);
        Journal2.SetActive(true);
        Journal3.SetActive(true);
    }
}
