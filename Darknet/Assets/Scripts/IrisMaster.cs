using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class IrisMaster : MonoBehaviour
{
    [SerializeField]
    GameObject backButton;
    [SerializeField]
    GameObject Chat1;
    [SerializeField]
    GameObject Chat2;
    [SerializeField]
    GameObject Chat3;

    [SerializeField]
    GameObject ChatLeft;
    [SerializeField]
    GameObject ChatRight;

    [SerializeField]
    GameObject messages;

    // Start is called before the first frame update
    void Start()
    {
        backButton.SetActive(false);
        Chat1.SetActive(true);
        Chat2.SetActive(true);
        Chat3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenBoss()
    {
        backButton.SetActive(true);
        Chat1.SetActive(false);
        Chat2.SetActive(false);
        Chat3.SetActive(false);
        string path = "Assets/Data/IndexBoss.txt";
        string pathChat = "Assets/Data/BossChat.txt";
        StreamReader streamReader = new StreamReader(path);

        //GameObject tempTextBox = Instantiate(ChatLeft, messages.transform.position, transform.rotation);
        //Text chatBox = tempTextBox.GetComponent<Text>();
        //chatBox.transform.SetParent(GameObject.FindGameObjectWithTag("UICanvas").transform, false);

        GameObject tempText = GameObject.Instantiate(ChatLeft);
        tempText.transform.SetParent(messages.transform, false);
        tempText.GetComponent<RectTransform>().anchoredPosition = messages.transform.position;
        //Text chatBox = tempText.GetComponent<Text>();

        Debug.Log("Start");
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            string[] words = line.Split('|');

            Debug.Log(HomeMaster.stage);
            if (words[0] == HomeMaster.stage)
            {
                StreamReader streamReaderChat = new StreamReader(pathChat);

                while (!streamReaderChat.EndOfStream)
                {
                    string msg = streamReaderChat.ReadLine();
                    string[] data = msg.Split('|');
                    foreach(string x in words)
                    {
                        if(x == data[0])
                        {
                            Debug.Log(data[1]);
                            tempText.GetComponent<Text>().text = data[1];
                        }
                    }
                }

                streamReaderChat.Close();
            }

            break;
        }
        
        streamReader.Close();
    }

    public void Back()
    {
        backButton.SetActive(false);
        Chat1.SetActive(true);
        Chat2.SetActive(true);
        Chat3.SetActive(true);
        //close all text files
    }
}
