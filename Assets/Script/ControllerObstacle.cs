using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerObstacle : MonoBehaviour
{
    [SerializeField]
    private VariableShared velocity  = null;
    [SerializeField]
    private float variantY  =0;
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variantY,variantY));
    }
    
    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocity.value * Time.deltaTime);   

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall")){
            this.Destruction();
        }
    }
    public void Destruction()
    {
        GameObject.Destroy(this.gameObject);
    }
}
