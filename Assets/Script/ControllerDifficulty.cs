using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDifficulty : MonoBehaviour
{
    [SerializeField]
    private float timePassedHard =0;
    private float timePassed =0;
    public float Difficult {get; private set;} 
    // Start is called before the first frame update


    // Update is called once per frame
    private void Update()
    {
        this.timePassed += Time.deltaTime;
        this.Difficult = this.timePassed / this.timePassedHard;
        this.Difficult = Mathf.Min(1,this.Difficult);
    }
}
