using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string sceneToLoad;


    public void GoToScene()
    {     
      SceneManager.LoadScene(sceneToLoad);  
    }
}
