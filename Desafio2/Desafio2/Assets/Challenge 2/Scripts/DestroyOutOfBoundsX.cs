using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la configuración de nuestros animales, es decir los perros que estamos lanzando
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class DestroyOutOfBoundsX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    private float leftLimit = -40; //Esta variable se le asigna el limite que tiene el perro
    private float bottomLimit = -5; //Esta variable se le asigna el limite que tiene nuestra pelota al caer

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        // Esta función nos ayuda a destruir los perros si la posición x es menor que el límite izquierdo.
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject); //Destruye el objeto, es decir el perro
        }
        // En otro caso esta función ayuda a destruir las bolas si la posición y es menor que bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject); //Destruye el objeto, es decir la pelota
        }

    }
}
