using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

public void ganti_scene(string scene_name){
    SceneManager.LoadScene(scene_name);
}
}
