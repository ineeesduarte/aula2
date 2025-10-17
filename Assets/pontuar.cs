using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class pontuar : MonoBehaviour
{
    
    public Transform jogador;
    public TMP_Text contar;
    void Update()
    {
        contar.text = "Pontuação: " + jogador.position.z.ToString("0");
    }
}
