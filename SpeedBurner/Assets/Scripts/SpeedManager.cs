using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int gameSpeed = 500;

    [SerializeField] GameObject gameOver;
    
    void Start()
    {
        StartCoroutine(GameStart());
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
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver(){
        yield return new WaitForSeconds(0.6f);
        gameOver.SetActive(true);
    }
}
