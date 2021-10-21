using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBananes : MonoBehaviour
{
    public GameObject[] bananes;
    public float limiteX1;
    public float limiteX2;
    public float limiteY1;
    public float limiteY2;
    public float limiteZ1;
    public float limiteZ2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreationBanane", 1f, 1f);
    }

    public void CreationBanane()
    {
        Instantiate(bananes[Random.Range(0, bananes.Length)], new Vector3(Random.Range(limiteX1, limiteX2), Random.Range(limiteY1, limiteY2), Random.Range(limiteZ1, limiteZ2)), gameObject.transform.rotation);
    }
}
