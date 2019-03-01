using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginButton : MonoBehaviour
{
    [SerializeField]
    Button login;
    string textValue;

    [SerializeField]
    InputField passwordText;

    // Start is called before the first frame update
    void Start()
    {
        login.enabled = false;
        passwordText.inputType = InputField.InputType.Password;
    }

    // Update is called once per frame
    void Update()
    {
        textValue = passwordText.text;
        if(textValue.Length == 1)
        {
            login.enabled = true;
        }
        else
        {
            login.enabled = false;
        }
    }

    public void Login()
    {
        textValue = passwordText.text;
        if(textValue == "?")
        {
            //Load new Scene
            SceneManager.LoadScene(1);
        }
    }
}
