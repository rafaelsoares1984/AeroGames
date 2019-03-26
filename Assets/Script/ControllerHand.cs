using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHand : MonoBehaviour
{
    private SpriteRenderer image = null;

    private void Awake()
    {
        this.image = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            this.HideHand();
        }

    }
    private void HideHand (){
        this.image.enabled = false;
    }
}
