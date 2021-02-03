using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;

public class CapsuleBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] SpeedManager speedManager;
    void Start()
    {
        OSCHandler.Instance.Init();
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/power", "ready");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            
            GameObject gameManager = GameObject.Find("GameManager");
            SpeedManager speedManager = gameManager.GetComponent<SpeedManager>();
            speedManager.gameSpeed += 70;
            Debug.Log($"Game Speed: {speedManager.gameSpeed}");
            //powerup sound
            OSCHandler.Instance.SendMessageToClient("pd", "/unity/power", 1);
            /*Debug.Log($"gameSpeed: {speedManager.gameSpeed}");
            speedManager.gameSpeed += 100;
            Debug.Log($"gameSpeed: {speedManager.gameSpeed}");*/
            Destroy(this.gameObject);
        }
        
    }
}
