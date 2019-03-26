using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Pointer : MonoBehaviour
{
    [SerializeField]
    private Text textoPointer  = null;
    [SerializeField]
    private UnityEvent toPointer  = null;
    public int Points {get;private set;}
    private AudioSource audioPointer  = null;

    private void Awake()
    {
        this.audioPointer = this.GetComponent<AudioSource>();
    }

    public void pointer(){
        this.AddPoints();
        this.audioPointer.Play();
    }


    public void AddPoints(){
        this.Points ++;
        this.textoPointer.text = Points.ToString();
        this.audioPointer.Play();
        this.toPointer.Invoke();
    }
     public void Restart()
    {
        this.Points = 0;
        this.textoPointer.text = this.Points.ToString();
    }
    public void SavePointer(){
        int recordNow = PlayerPrefs.GetInt("record");
        if (this.Points > recordNow){
            PlayerPrefs.SetInt("record",this.Points);
        }
    }
}
