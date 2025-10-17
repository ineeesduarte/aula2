using UnityEngine;
using UnityEngine.InputSystem;

public class moverjogador : MonoBehaviour
{
public Rigidbody jogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        jogador.AddForce(0, 0, 4);
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            jogador.AddForce(-4,0,0);
        }
        if(Keyboard.current.rightArrowKey.isPressed)
        {
            jogador.AddForce(+4,0,0);
        }
    }

    private void OnCollisionEnter(Collision quem)
    {
        if (quem.gameObject.tag == "Bom")
        {

            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}