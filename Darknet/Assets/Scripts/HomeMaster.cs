using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeMaster : MonoBehaviour
{
    bool isCrpyt, isIris, isCronus;

    // Start is called before the first frame update
    void Start()
    {
        isCrpyt = false;
        isIris = false;
        isCronus = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenIris()
    {
        if (!isIris)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
            isIris = true;
        }
        else
        {
            SceneManager.UnloadSceneAsync(2);
            isIris = false;
        }
    }

    public void OpenCrpyt()
    {
        if (!isCrpyt)
        {
            SceneManager.LoadScene(3, LoadSceneMode.Additive);
            isCrpyt = true;
        }
        else
        {
            SceneManager.UnloadSceneAsync(3);
            isCrpyt = false;
        }
    }

    public void OpenCronus()
    {
        if (!isCronus)
        {
            SceneManager.LoadScene(4, LoadSceneMode.Additive);
            isCronus = true;
        }
        else
        {
            SceneManager.UnloadSceneAsync(4);
            isCronus = false;
        }
    }
}
