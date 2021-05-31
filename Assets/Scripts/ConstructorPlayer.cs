using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPlayer 
{
    //Atributos propiedades

public int PlayerId;  
public float vida;
public float velocidad;
public Color color;
public string nombre;

private Transform PosicionActual;
private int daño;

      //Metodo constructor
      public ConstructorPlayer(int id, float vida, float velocidad, string n){
      this.PlayerId=id;
      this.vida=vida;
      this.velocidad=velocidad;
      this.nombre=n;
      }

}
