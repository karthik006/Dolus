using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeMaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenIris()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }

    public void CpenCrpyt()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
    }
}
