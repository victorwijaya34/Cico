using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GendertoLayar : MonoBehaviour
{
    public void Layar()
	{
		SceneManager.LoadScene ("Layar");
	}
public void Layar2()
	{
		SceneManager.LoadScene ("Layar2");
	}
    public void Back()
	{
		SceneManager.LoadScene ("PilihGender");
	}
}
