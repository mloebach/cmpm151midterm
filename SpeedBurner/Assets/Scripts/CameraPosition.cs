using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject playerUnit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerUnit.transform.position.x+5, transform.position.y, transform.position.z);
    }
}
