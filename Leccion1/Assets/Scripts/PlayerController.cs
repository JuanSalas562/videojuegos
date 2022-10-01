using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*Autor: Cabello Salas Juan Carlos
Fecha: 29/09/22
Grupo: GDGS2102 - 1219100562
Scrip: Este scrip es el scrip principal. Que usaremos para manipular el funcionamiento de nuestro player, es decir, nuestro carro.
*/
public class PlayerController : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{

    private float speed = 12.0f; //Esta variable la utilice para asigarle la velocidad a mi coche.
    private float turnSpeed = 25.0f; //Variable para la velocidad de rotación del vehiculo
    private float horizontalInput; // Esta variable se creo para controlar el movimiento de derecha y izquierda del automovil.
    private float forwardInput; // Esta variable se creo para controlar el acelerador y el freno del automovil.

    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        
    }

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal"); //Función para el movimiento derecha y izquierda
        forwardInput = Input.GetAxis("Vertical"); //Función para el movimiento acelerar y frenar.

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);//Esta linea de codigo se utilizo para hacer que nuestro vehiculo se desplaze en nuestra carretera y tambien asignarle una velocidad al momento en el que avance
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);//Esta linea de codigo se utilizo para hacer que nuestro vehiculo pueda girar de derecha a izquierda para no chocar con los obstaculos.
        
    }
}
