using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    [SerializeField]
    private float timeForGenerateEasy  =0;
    [SerializeField]
    private float timeForGenerateHard =0;
    [SerializeField]
    private GameObject Obstacle  = null;
    private float chronometer  =0;
    private ControllerDifficulty difficulty  = null;
    private bool stoped;
    
    // Start is called before the first frame update


    private void Awake()
    {
      this.chronometer = this.timeForGenerateEasy;
    }
    private void Start()
    {
        this.difficulty = GameObject.FindObjectOfType<ControllerDifficulty>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (this.stoped){
            return;
        }
        this.chronometer -= Time.deltaTime;
        if (this.chronometer < 0)
        {
           GameObject.Instantiate(this.Obstacle,this.transform.position,Quaternion.identity);
           this.chronometer = Mathf.Lerp(this.timeForGenerateEasy,this.timeForGenerateHard,this.difficulty.Difficult);
        } 
    }
    public void Disable()
    {
       this.stoped = true;

    }
    public void Enabled()
    {
       this.stoped = false;

    }
}
