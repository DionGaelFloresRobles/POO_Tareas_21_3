using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
    //cambio en experimentoarray
    public ConstructorPlayer[] nuevoJugador;
     
    // Start is called before the first frame update
    void Start()
    {
     nuevoJugador= new ConstructorPlayer[4];
     nuevoJugador[0]= new ConstructorPlayer(1, 10, 10, "Superman");
     nuevoJugador[1]= new ConstructorPlayer(2, 15, 10, "Zod");
     nuevoJugador[2]= new ConstructorPlayer(3, 40, 5, "Doomsday");
     nuevoJugador[3]= new ConstructorPlayer(4, 9, 15, "Supergirl");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
