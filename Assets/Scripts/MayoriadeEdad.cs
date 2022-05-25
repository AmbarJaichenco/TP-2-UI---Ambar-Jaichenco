using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MayoriadeEdad : MonoBehaviour
{
    public int edadusr;
    public Text myText;


    // Start is called before the first frame update
    void Start()
    {
        

        if(edadusr >= 18)
        {
            myText.text = "Es mayor de edad";
        }

        else
        {
            myText.text = "No es mayor de edad";
        }
    }


}
