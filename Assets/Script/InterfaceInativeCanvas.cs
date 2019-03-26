using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceInativeCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject backgorund  = null;
    [SerializeField]
    private Canvas canvas = null;

    [SerializeField]
    private Text textOfRefive = null;
    private void Awake()
    {
        this.canvas = this.GetComponent<Canvas>();
    }
    public void Show(Camera camra){
        this.backgorund.SetActive(true);
        this.canvas.worldCamera = camra;

    }
    public void UpdateText(int pointsOfRevival){
        this.textOfRefive.text = pointsOfRevival.ToString();
    }

    public void Hide()
    {
        this.backgorund.SetActive(false);
    }
}
