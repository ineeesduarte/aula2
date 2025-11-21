using UnityEngine;
using UnityEngine.SceneManagement;

public class controla : MonoBehaviour
{
    bool fim = false;

    public void acabou()
    {
        if (fim) return;
        fim = true;

        Time.timeScale = 0f;

        Invoke(nameof(recomecar), 2f);
    }

    void recomecar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel 1");
    }
}
