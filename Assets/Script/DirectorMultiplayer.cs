using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorMultiplayer : Director
{
    private int pointsOfDie=0;
    private bool someoneIsDie;
    private Player[] players = null;
    private InterfaceInativeCanvas interfaceInativeCanvas = null;
    [SerializeField]
    private int pointsOfRevive = 0;

    protected override void Start()
    {
        this.players = GameObject.FindObjectsOfType<Player>();
        base.Start();
        this.interfaceInativeCanvas = GameObject.FindObjectOfType<InterfaceInativeCanvas>();
    }

    public void ReviveIfNeed(){
        if (this.someoneIsDie){
            this.pointsOfDie++;
            this.interfaceInativeCanvas.UpdateText(this.pointsOfRevive-this.pointsOfDie);
            if (this.pointsOfDie >= pointsOfRevive){
                this.interfaceInativeCanvas.Hide();
                this.RevivePlayer();
            }
        }
    }

    private void RevivePlayer()
    {
        this.someoneIsDie = false;
        foreach(var player in this.players){
            player.EnabledPlayer();
        }
    }

    public void SomeoneDie(Camera camera){
        if (this.someoneIsDie){
            this.interfaceInativeCanvas.Hide();
            this.stopGame();
        }else{
            this.someoneIsDie = true;
            this.pointsOfDie=0;
            this.interfaceInativeCanvas.Show(camera);
            this.interfaceInativeCanvas.UpdateText(this.pointsOfRevive);
        }
    }

    public override void RestartGame(){
        base.RestartGame();
        this.RevivePlayer();
    
    }


}
