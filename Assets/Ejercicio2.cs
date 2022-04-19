using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float metros;
        public float años;
    // Start is called before the first frame update
    void Start()
    {
        if (metros > 1.2 || años > 13 )
        {
            Debug.Log("Tiene permitida la entrada");
        }
        else if ( metros < 1.2 || años < 13)
        {
            Debug.Log("Usted no tiene permitida la entrada");
        }
        if (años < 1  || metros < 0)
        {
            Debug.Log("Error");
       
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
