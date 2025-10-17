using UnityEngine;

public class seguir : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform jogador;
    public Vector3 distancia;
    void Update()
    {
       transform.position = jogador.position+distancia; 
    }
}