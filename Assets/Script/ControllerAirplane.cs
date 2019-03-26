using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerAirplane : MonoBehaviour
{
    private Rigidbody2D physics = null;
    [SerializeField]
    private float force  =0;
    [SerializeField]
    private UnityEvent isHit =null;
    [SerializeField]
    private UnityEvent isTigerObstacle = null;
    private Vector3 positionInitial ;
    private bool isBoost =false;
    private Animator animator  = null;
    private void Awake()
    {
        this.physics = this.GetComponent<Rigidbody2D>();
        this.positionInitial = this.transform.position;
        this.animator = this.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    public void Reload()
    {
        this.transform.position = this.positionInitial;
        this.physics.simulated = true;
    }

    // Update is called once per frame
    private void Update()
    {
        this.animator.SetFloat("VelocityY",this.physics.velocity.y);
    }
    public void IsBoost(){
        this.isBoost =true ;
    }   

    private void FixedUpdate()
    {
        if(this.isBoost){
            this.Boost();
        }
    }

    private void Boost()
    {
        this.physics.velocity = Vector2.zero;
        this.physics.AddForce(Vector2.up * this.force, ForceMode2D.Impulse);
        this.isBoost = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        this.physics.simulated = false;
        this.isHit.Invoke();;
    }

    private  void OnTriggerEnter2D(Collider2D other)
    {
        this.isTigerObstacle.Invoke();
    }

}
