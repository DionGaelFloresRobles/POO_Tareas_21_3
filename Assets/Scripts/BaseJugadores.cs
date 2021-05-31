using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{

    public ConstructorPlayer Superman = new ConstructorPlayer();

    public ConstructorPlayer Zod = new ConstructorPlayer();

     
    // Start is called before the first frame update
    void Start()
    {
        Superman.nombre="Superman";
        Superman.PlayerId=1;
        Superman.vida=5;
        Superman.velocidad=6f;
        
         Zod.nombre="Zod";
         Zod.PlayerId=2;
         Zod.vida=5;
         Zod.velocidad=8f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
