using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
*Autor: Cabello Salas Juan Carlos
Fecha: 23/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip fue creado para el funcionamiento, configuración y control de nuestro Player.
*/
public class MoveHuman : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    public float vel = 100.0F; // Se crea la variabvle para asignarle la velocidad a nuestro player
    public float maximo = 22; // Esta variable sirve para asignar el rango hasta donde se puede mover nuestro player
    public GameObject Pizza; // Variable de nuestro objeto Pizza- el alimento


    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        
    }

     // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            Instantiate(Pizza, transform.position, Pizza.transform.rotation); // Función que utilizamos para lanzar la pizza desde la posición del player
        }
        
        if(transform.position.x > maximo){
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z); //Función que se se asigna al player, del rango de movimiento, para que no se salga del mapa- Izquierda
        }

        if(transform.position.x < -maximo){
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z); //Función que se se asigna al player, del rango de movimiento, para que no se salga del mapa- Derecha
        }
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas); // Esta función nos permite manipular el player con los controles
    }
}
