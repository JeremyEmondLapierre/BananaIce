using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCoconut : MonoBehaviour
{
    
    
    void OnCollisionEnter(Collision infoCollision){
        //Fonction pour détecter la collision avec une banane
         if(infoCollision.gameObject.tag== "Banane"){
             //Si on touche une banane dorée, on double le score pour le reste de la partie
            if(infoCollision.gameObject.name=="BananeDoree(Clone)"){
                GestionnaireScore.Double = true;
            }
            //Si on touche une banane normale, on donne 3 points
            else if(infoCollision.gameObject.name=="Regulobana(Clone)"){
                GestionnaireScore.Score += 3;
                if(GestionnaireScore.Double){
                    GestionnaireScore.Score += 6;
                }
            }
            //Si on touche une banane de glace, on donne 8 points
            else if(infoCollision.gameObject.name=="Bananaglace(Clone)"){
                GestionnaireScore.Score += 8;
                if(GestionnaireScore.Double){
                    GestionnaireScore.Score += 16;
                }
            }
            //Si on touche une banane de feu, on donne 15 points
            else if(infoCollision.gameObject.name=="Bananafeu(Clone)"){
                GestionnaireScore.Score += 15;
                if(GestionnaireScore.Double){
                    GestionnaireScore.Score += 30;
                }
            }
            //On lui permet de tomber
            infoCollision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //On la détruit après 2 secondes
            Destroy(infoCollision.gameObject, 2f);
         }

        //Si on touche les trous d'Eau, on perd 10 points
        if(infoCollision.gameObject.name == "Eau"){
            GestionnaireScore.Score -= 10;
            Destroy(gameObject,2f);
        }
    }
}
