

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
    ///  se crea el metodo result que calcula el resultado de la compuerta Not
    /// </summary>
    /// <returns></returns>
    public override int result()
    {
        int result = 0;
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