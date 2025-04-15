using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptPlacar : MonoBehaviour
{
    private static int placar = 0; 
    private static GameObject texto;
    public void Start(){
        texto = GameObject.Find("txtPlacar");
    }
    public static void addPlacar(int a){
        placar += a;
        texto.GetComponent<TMP_Text>().text = "Placar: " + placar;
    }
    
}
