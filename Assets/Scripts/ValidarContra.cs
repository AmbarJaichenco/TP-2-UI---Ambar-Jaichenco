using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contra_correcta;
    string contra_usr;
    public Text ingresousr;
    public GameObject msj;
    public Text txtmsj;


    // Start is called before the first frame update
    void Start()
    {
        contra_correcta = "12345";
        msj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarContrasenia()
    {
        contra_usr = ingresousr.text;
        if(contra_usr == contra_correcta)
        {
            msj.SetActive (true);
            txtmsj.text = "Bienvenido";
        }
        else
        {
            msj.SetActive(true);
            txtmsj.text = "Contrasena Incorrecta";
        }
    }
}
