using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la configuración de nuestros animales, es decir los perros que estamos lanzando
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class DetectCollisionsX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
