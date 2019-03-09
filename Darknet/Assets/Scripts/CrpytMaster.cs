using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CrpytMaster : MonoBehaviour
{
    [SerializeField]
    Text displayText;

    [SerializeField]
    Text hashText;

    // Start is called before the first frame update
    void Start()
    {
        displayText.text = "";
        hashText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NumberButton()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        displayText.text += name;
    }

    public void GoButton()
    {
        if(displayText.text == "12345")
        {
            hashText.text = "54321";
        }
        else
        {
            hashText.text = "";
            displayText.text = "";
        }
    }
}
