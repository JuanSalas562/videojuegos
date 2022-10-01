using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*Autor: Cabello Salas Juan Carlos
Fecha: 23/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip fue creado para el movimiento de los animales.
*/
public class MoveAnimals : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        
    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        if(transform.position.z < -14.1){ // Esta función se le asigna una posición en un numero asignado.
            Destroy(gameObject); //Se le agrega el GameObject
        }


        transform.Translate(Vector3.forward * Time.deltaTime * 10); //Esta función sirve para el movimiento de los animales y el tiempo en que reaparecen.
    }
}
