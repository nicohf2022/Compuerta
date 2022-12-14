using System;
namespace Library;
/// <summary>
/// se crea la clase CompuertaNot que hereda de la clase Compuertas
/// </summary>
public class  CompuertaNot:Compuertas
{
    /// <summary>
    ///  se crea el constructor de la clase CompuertaNot
    /// </summary>
    /// <param name="name"></param>
    public CompuertaNot(String name):base(name)
    {
        
        
    }
     /// <summary>
    ///  se crea el metodo result que calcula el resultado de la compuerta Not y la excepcion que se lanza si no tiene 1 entrada.
    /// </summary>
    /// <returns></returns>
    public override int result()
    {
        int result = 0;
        if (Input.Count != 1)
        {
            throw new ExeptionCant("La compuerta no tiene 1 entrada");
        }
        
        foreach (var e in Input)
        {
            if (e.Value.result() == 1)
            {
                result = 0;
            }
            else if  (e.Value.result()==0)
            {
                result = 1;
            }
            
            
        
        }       
        return result;
    }
}