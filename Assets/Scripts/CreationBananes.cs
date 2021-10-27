using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBananes : MonoBehaviour
{
    //Déclaration des limites et du tableau des bananes
    public GameObject[] bananes;
    public float limiteX1;
    public float limiteX2;
    public float limiteY1;
    public float limiteY2;
    public float limiteZ1;
    public float limiteZ2;
    public float vitesseSpawnBananes;
    

    // Start is called before the first frame update
    void Start()
    {
        //Invoquer une bananane à chaque une seconde
        InvokeRepeating("CreationBanane", 1f, vitesseSpawnBananes);
    }

    public void CreationBanane()
    {
        //Instantier la banane
        GameObject NouvelleBanane = Instantiate(bananes[Random.Range(0, bananes.Length)], new Vector3(Random.Range(limiteX1, limiteX2), Random.Range(limiteY1, limiteY2), Random.Range(limiteZ1, limiteZ2)), gameObject.transform.rotation);
        //On détruit la banane dorée à chaque 10 secondes
        if(NouvelleBanane.name == "BananeDoree(Clone)"){
            Destroy(NouvelleBanane.gameObject, 10f);
        }
    }
}
