using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Carousel[] scenery  = null;
    private GenerateObstacle generateObstacle  = null;
    private ControllerAirplane controllerAirplane  = null;
    private bool hasDie; 
    // Start is called before the first frame update
    void Start()
    {
        this.scenery = this.GetComponentsInChildren<Carousel>();
        this.generateObstacle = this.GetComponentInChildren<GenerateObstacle>();
        this.controllerAirplane = this.GetComponentInChildren<ControllerAirplane>();
    }

    public void DisabelePlayer()
    {
        this.hasDie=true;
        this.generateObstacle.Disable();
        foreach(var carrousel in this.scenery){
            carrousel.enabled = false;
        }
    }

    public void EnabledPlayer()
    {
        if (this.hasDie){
            this.controllerAirplane.Reload();
            this.generateObstacle.Enabled();
            foreach(var carrousel in this.scenery){
                carrousel.enabled = true;
            }
            this.hasDie=false;
        }
    }

}
