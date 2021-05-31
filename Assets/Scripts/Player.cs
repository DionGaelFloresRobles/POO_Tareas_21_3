using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float vida;
   public float velocidad;
   public string nombre;
   public int PlayerId;

   //BaseJugadores bdjugadores = new BaseJugadores(); 
    BaseJugadores bdjugadores; 

   private void Start() {

       bdjugadores = GameObject.FindObjectOfType<BaseJugadores>();
     

   }



}
