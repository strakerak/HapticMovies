using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadBD()
    {
        SceneManager.LoadScene("BabyDriver");
    }

    public void LoadJ()
    {
        SceneManager.LoadScene("Jaws");
    }
}
