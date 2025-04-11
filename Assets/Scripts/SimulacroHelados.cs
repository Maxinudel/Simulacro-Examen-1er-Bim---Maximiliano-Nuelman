using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroHelados : MonoBehaviour
{

    public string gusto;
    public float gramos;
    float precioGramos;

    // Start is called before the first frame update
    void Start()
    {
        precioGramos = 1.25f;

        if(gramos<250 || gramos > 3000)
        {
            Debug.Log("Error");
        }else if (gusto == "FRU")
        {
            Debug.Log("Tienes que pagar $" + precioGramos * gramos* 90/100);
        }else if(gusto=="DDL" || gusto == "CHO")
        {
            Debug.Log("Tienes que pagar $" + precioGramos * gramos);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
