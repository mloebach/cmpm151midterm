using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] SpeedManager speedManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    float moveSpeed = 8.0f;
    void Update()
    {
        //Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        float xSpeed = speedManager.gameSpeed * 0.003f;
        Vector3 movement = new Vector3 (xSpeed, Input.GetAxis("Vertical"), 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        //-3.5 to 5.5
        if(transform.position.y > 5.5){
            transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z);
        }
        if(transform.position.y < -3.5){
            transform.position = new Vector3(transform.position.x, -3.5f, transform.position.z);
        }
    }

    /*
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "PowerUp"){
            Debug.Log($"gameSpeed: {speedManager.gameSpeed}");
            speedManager.gameSpeed += 100;
            Debug.Log($"gameSpeed: {speedManager.gameSpeed}");
            Destroy(col.gameObject);
        }
        
    }*/
}
