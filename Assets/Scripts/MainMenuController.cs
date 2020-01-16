using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
public void PlayGame(){
// Application.LoadLevel("Gameplay");
SceneManager.LoadScene(1);
}
}
