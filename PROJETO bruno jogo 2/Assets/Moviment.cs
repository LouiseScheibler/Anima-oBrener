using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do jogador.

    void Update()
    {
        // Obtém as entradas do teclado (setas ou teclas W, A, S, D).
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula a direção de movimento com base nas entradas do teclado.
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move o jogador na direção calculada.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

