using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    // Function must be called by us, not automatically by Unity
    public void LoadTargetScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}