	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void BackPage()
	{
		SceneManager.LoadScene ("Pria");
	}
	public void BackPage2()
	{
		SceneManager.LoadScene ("Wanita");
	}
}
