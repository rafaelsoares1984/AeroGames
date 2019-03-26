using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerIA : MonoBehaviour
{
    [SerializeField]
    private float intervalBoost  =0;
    [SerializeField]
    private ControllerAirplane controllerAirplane;
    // Start is called before the first frame update
    private void Start()
    {
        this.controllerAirplane = this.GetComponent<ControllerAirplane>();
        StartCoroutine(this.Boost());
    }

    private IEnumerator Boost()
    {
        while(true){
            yield return new WaitForSeconds(intervalBoost);
            this.controllerAirplane.IsBoost();
        }

    }

}
