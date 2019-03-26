using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    [SerializeField]
    private VariableShared velocity  = null;
    private Vector3 positionInitial;
    private float sizeFloorReal =0;
    
    private void Awake()
    {
        this.positionInitial = this.transform.position;    
        float sizeFloor = this.GetComponent<SpriteRenderer>().size.x;
        float scale = this.transform.localScale.x;
        this.sizeFloorReal = sizeFloor * scale;

    }

    // Update is called once per frame
    private void Update()
    {
        float deslocate = Mathf.Repeat(this.velocity.value * Time.time,this.sizeFloorReal/2);

        this.transform.position = this.positionInitial + (Vector3.left * deslocate);
    }
}
