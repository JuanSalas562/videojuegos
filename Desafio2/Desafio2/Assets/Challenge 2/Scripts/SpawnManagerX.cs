using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Autor: Cabello Salas Juan Carlos
* Script: Este script fue creado para la generación de nuestros objetos automaticamente.
* Grupo: GDGS2102 - 1219100562
* Fecha: 20/09/22
*/
public class SpawnManagerX : MonoBehaviour //Esta clase heredara parte de MonoBehaviour
{
    public GameObject[] ballPrefabs; // Trae el arreglo de nuestros objetos

    private float spawnLimitXLeft = -22; //Variable la posición de la para creación
    private float spawnLimitXRight = 7; //Variable la posición de la para creación
    private float spawnPosY = 30; //Variable la posición de la para creación

    private float startDelay = 1.0f;
   // private float spawnInterval = 4.0f;

    // Este es nuestro metodo start que cuando corremos nuestro juego, este se inicializa.
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay); //Inicia el metodo de invoke automaticamente antes de empezar
    }

    // Este metodo nos ayuda a Generar bolas aleatorias en una posición aleatoria x en la parte superior del área de juego
    void SpawnRandomBall ()
    {

        int pelota = Random.Range(0, 3); //Variable para hacer que el color de la pelota varie

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0); // Esta función genera índice de bola aleatorio y posición de generación aleatoria
        
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[pelota].transform.rotation); // Esta función instancia la bola en una ubicación de generación aleatoria

        startDelay = Random.Range(1, 5); //Esta función ayuda a que las bolas aparezcan en diferentes sitios

        Invoke("SpawnRandomBall", startDelay); //invoca la creación de bolas random
    }

}
