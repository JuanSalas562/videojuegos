using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la configuración y control del movimiento de nuestros perros. al momento de lanzarlo
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class MoveForwardX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    // Agregamos una variable para darle una velocidad al momento de avanzar.
    public float speed;

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
