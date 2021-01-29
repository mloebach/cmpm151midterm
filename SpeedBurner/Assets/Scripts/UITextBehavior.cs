using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UITextBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text gameText;

    [SerializeField] SpeedManager speedManager;
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedManager.gameSpeed;
        string scoreString = "999";
        gameText.color = Color.black;
        if(speed < 10){
            scoreString = "00" + speed.ToString();
            gameText.color = Color.red;
        }else if(speed < 100){
            scoreString = "0" + speed.ToString();
            gameText.color = Color.red;
        }else{
            scoreString = speed.ToString();
        }
        gameText.text = "Stock: " + scoreString + "USD"; 
        
    }
}
