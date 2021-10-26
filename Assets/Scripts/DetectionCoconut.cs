using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCoconut : MonoBehaviour
{

    public GameObject Coconut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision infoCollision){
        if(infoCollision.gameObject.name== "Coconut"){
            
        }
        else{
            Instantiate(Coconut, new Vector3(9.477f,-33.962f,-175.476f), gameObject.transform.rotation);
        }
    }
}
