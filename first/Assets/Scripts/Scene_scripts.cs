using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_scripts : MonoBehaviour
{
    public void changescene_to_main()
    {
        SceneManager.LoadScene(0);
    }
}
