using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerMenu : MonoBehaviour
{
    public GameObject exit;
    void Start()
    {
       #if UNITY_STANDALONE || UNITY_EDITOR
            exit.SetActive(true);
       #endif
    }
    public void LoadSingle(){
        StartCoroutine(ChanceScene("AeroGame"));
        
    }
    public void LoadMulti(){
        StartCoroutine(ChanceScene("AeroGameMult"));
    }

    public void QuitGame(){
        StartCoroutine(QuitScene());
    }

    IEnumerator ChanceScene(string scene){
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }

    IEnumerator QuitScene(){
        yield return new WaitForSeconds(0.3f);
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif    
    }

}
