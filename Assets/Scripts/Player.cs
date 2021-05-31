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
       this.nombre= bdjugadores.Superman.nombre;
       this.PlayerId= bdjugadores.Superman.PlayerId;
       this.vida= bdjugadores.Superman.vida;
       this.velocidad= bdjugadores.Superman.velocidad;

   }



}
