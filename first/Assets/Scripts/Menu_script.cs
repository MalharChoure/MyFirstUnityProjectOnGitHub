using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_script : MonoBehaviour
{
    public void scene_1() {changescene(1);}

    public void scene_2() {changescene(2);}

    public void scene_3() {changescene(3);}

    public void changescene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
