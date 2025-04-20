using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControladorJogo : MonoBehaviour
{
    // Start is called before the first frame update
    private bool pausa;
    void Start()
    {
        pausa = false;
    }

    // Update is called once per frame
   void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        pausa = !pausa; 

        if (pausa)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}

}
