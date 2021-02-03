using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;

public class SpeedManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int gameSpeed = 500;
    public bool end = false;

    [SerializeField] GameObject gameOver;
    
    void Start()
    {
        StartCoroutine(GameStart());
        OSCHandler.Instance.Init();
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/loss", "ready");
    }

    IEnumerator GameStart(){
        //Debug.Log("test");
        while(true){
            //Debug.Log("test");
            yield return new WaitForSeconds(0.15f);
            gameSpeed -= 6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameSpeed > 500){
            gameSpeed = 500;
        }
        if(gameSpeed < 0){
            gameSpeed = 0;
            if(end == false) { 
                //end sound
                OSCHandler.Instance.SendMessageToClient("pd", "/unity/loss", 1);
                end = true;
            }
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver(){
        yield return new WaitForSeconds(0.6f);
        gameOver.SetActive(true);
    }
}
