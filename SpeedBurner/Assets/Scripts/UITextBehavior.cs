using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityOSC;
public class UITextBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text gameText;

    [SerializeField] SpeedManager speedManager;
    public int speed;
    void Start()
    {
        OSCHandler.Instance.Init ();
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/trigger", "ready");
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
            OSCHandler.Instance.SendMessageToClient ("pd", "/unity/trigger", speed);
        }else if(speed < 100){
            scoreString = "0" + speed.ToString();
            gameText.color = Color.red;
            OSCHandler.Instance.SendMessageToClient ("pd", "/unity/trigger", speed);
        }else{
            scoreString = speed.ToString();
            OSCHandler.Instance.SendMessageToClient ("pd", "/unity/trigger", speed);
        }
        gameText.text = "Stock: " + scoreString + "USD"; 
        
    }
}
