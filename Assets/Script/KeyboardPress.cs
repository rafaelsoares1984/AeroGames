using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardPress : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCode = 0;
     [SerializeField]
    private UnityEvent isPressKeyboard = null;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(this.keyCode)){
            this.isPressKeyboard.Invoke();
        }
    }
}
