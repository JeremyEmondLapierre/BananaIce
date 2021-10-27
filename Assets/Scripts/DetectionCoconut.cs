using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCoconut : MonoBehaviour
{
    //Déclaration des GameObject utile dans le jeu
    public GameObject Coconut; //Prefab de la coconut

    //Fonction qui sert à détecter quand il ne reste que 3 coconuts dans le bac. Génération d'une nouvelle
    void OnTriggerExit(Collider infoCollision){
        //Si le détecteur ne touche plus à une coconut...
        if(infoCollision.gameObject.tag== "Coconut"){
            //Instantiate la coconut
            Instantiate(Coconut, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
