using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCoconut : MonoBehaviour
{
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision infoCollision){
        if(infoCollision.gameObject.name== "Bananafeu(Clone)" || infoCollision.gameObject.name== "Bananaglace(Clone)" || infoCollision.gameObject.name== "BananeDoree(Clone)" || infoCollision.gameObject.name== "Regulobanana(Clone)"){
            score.GetComponent<TextMesh>().text += 1;
        }
    }
}
