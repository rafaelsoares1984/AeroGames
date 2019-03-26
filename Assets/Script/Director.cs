using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
   
    private ControllerAirplane airplane  = null;
    private Pointer pointer  = null;                          
    // Start is called before the first frame update
    private InterfaceGameOver interfaceGameOver  = null;
    protected virtual void Start()
    {
        this.airplane = GameObject.FindObjectOfType<ControllerAirplane>();
        this.pointer = GameObject.FindObjectOfType<Pointer>();
        this.interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
    }

    public void stopGame()
    {
        Time.timeScale = 0;
        this.pointer.SavePointer();
        this.interfaceGameOver.ShowInterface();
    }
    public void RestartGame()
    {
        this.interfaceGameOver.HideInterface();
        Time.timeScale = 1;
        this.airplane.Reload();
        this.DestructionObstacle();
        this.pointer.Restart();
    }
    private void DestructionObstacle()
    {
        ControllerObstacle[] obstacles =GameObject.FindObjectsOfType<ControllerObstacle>();
        foreach(ControllerObstacle obstacle in obstacles)
        {
           obstacle.Destruction(); 
        }
    }
}
