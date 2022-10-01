using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para el bono de la función de hacer rotar la hélice de nuestra avioneta.
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class HeliceAvion : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{

    //Creación de variable para la velocidad en la quw rotara la hélice
    public float rotacion = 950.0f;

    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        
    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        
        transform.Rotate(Vector3.forward * rotacion); //En la parte de arriba se agrego la variable  con los valores de velocidad asignados. Y Aqui se hace la función para que la helice rote.
    }
}
