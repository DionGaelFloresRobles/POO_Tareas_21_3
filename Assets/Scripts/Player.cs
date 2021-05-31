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
     
    CargarDatos(PlayerId);
   }

  void CargarDatos (int id){
      for (int i = 0; i < bdjugadores.nuevoJugador.Length; i++)
      {
          if (bdjugadores.nuevoJugador[i].PlayerId==id)
          {
           this.nombre= bdjugadores.nuevoJugador[i].nombre; 
         this.velocidad= bdjugadores.nuevoJugador[i].velocidad; 
         this.vida= bdjugadores.nuevoJugador[i].vida;    
          }
         
      }  
    }

}
