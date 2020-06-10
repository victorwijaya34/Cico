using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void vans1()
    {
        SceneManager.LoadScene("Layar1A");
    }
    public void vans2()
    {
        SceneManager.LoadScene("Layar1B");
    }
    public void vansback()
    {
        SceneManager.LoadScene("Layar");
    }

    public void heels1()
    {
        SceneManager.LoadScene("Layar2A");
    }
    public void heels2()
    {
        SceneManager.LoadScene("Layar2B");
    }
    public void heelsback()
    {
        SceneManager.LoadScene("Layar2");
    }
}
