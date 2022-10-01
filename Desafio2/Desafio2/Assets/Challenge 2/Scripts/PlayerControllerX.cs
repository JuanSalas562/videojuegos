using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la configuración, control y función de nuestro player.
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class PlayerControllerX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    private float tiempoDisparo = 1; //Esta variable se creo para darle un tiempo al momento en que dispara un perro
    private float tiempoSigDisparo = 0;  //Esta variable se creo para darle un tiempo al momento en que realiza el segundo disparo del perro
    public GameObject dogPrefab;

    // Este metodo de update, consiste en que estara constantemente verificando los distintos calculos que nuestro juego deberia hacer o distintas cosas que debe comparar.
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSigDisparo) // Esta función nos sirve para cuando presione la barra espaciadora, el player envía perro
        {
            tiempoSigDisparo = Time.time + tiempoDisparo;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); //Aqui instancea el prefaf de los perros, al momento de disparar envia 1
        }
    }
}
