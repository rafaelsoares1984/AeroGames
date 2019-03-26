using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text valueRecord  = null;

    [SerializeField]
    private GameObject imageGameOver  = null;
    private Pointer pointer  = null;
    private int record = 0;
    [SerializeField]
    private Image imageMedal  = null;
    [SerializeField]
    private Sprite imageMedalGold  = null;
    [SerializeField]
    private Sprite imageMedalSilver  = null;
    [SerializeField]
    private Sprite imageMedalBronze = null;

    // Start is called before the first frame update
    private void Start()
    {
        this.pointer = GameObject.FindObjectOfType<Pointer>();
    }

    public void ShowInterface(){
        this.imageGameOver.SetActive(true);
        this.UpdateInterface();
    }

    public void HideInterface(){
        this.imageGameOver.SetActive(false);
    }

    private void UpdateInterface(){
        this.record = PlayerPrefs.GetInt("record");
        this.valueRecord.text = this.record.ToString();
        this.VerifyMedal();
    }
    private void VerifyMedal(){

        if (this.pointer.Points > this.record-2){
            this.imageMedal.sprite = imageMedalGold;
        }else if (this.pointer.Points > this.record/2){
            this.imageMedal.sprite = imageMedalSilver;
        }else{
            this.imageMedal.sprite = imageMedalBronze;
        }
    }
}
