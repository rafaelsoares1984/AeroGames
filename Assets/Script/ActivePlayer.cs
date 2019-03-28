using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivePlayer : MonoBehaviour
{
    [SerializeField]
    private UnityEvent finalAnimation = null;
    public void Active(){
        this.finalAnimation.Invoke();
    }
}
