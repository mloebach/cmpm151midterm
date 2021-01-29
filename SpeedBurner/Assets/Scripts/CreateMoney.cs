using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMoney : MonoBehaviour
{
    //Starting from x = 10, create a new pod every 15 xs
    [SerializeField] GameObject playerCube;
    public GameObject Capsule;
    float nextCapsuleX = 5;
    void Update()
    {
        float playerX = playerCube.transform.position.x;
        //Debug.Log($"{playerX} == {nextCapsuleX}");
        if(playerX >= nextCapsuleX){
            Instantiate(Capsule, new Vector3(playerX+20, Random.Range(-3.5f, 5.5f), 0), Quaternion.identity);
            nextCapsuleX += Random.Range(10,35);
        };
    }
}
