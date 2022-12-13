namespace Library;
/// <summary>
/// se crea la clase CompuertasAnd que hereda de la clase Compuertas
/// </summary>
public class CompuertasAnd:Compuertas
{
    /// <summary>
    ///  se crea el constructor de la clase CompuertasAnd
    /// </summary>
    /// <param name="name"></param>
    public CompuertasAnd(string name):base(name)
    {
        
    }
    /// <summary>
    /// se crea el metodo result que calcula el resultado de la compuerta And
    /// </summary>
    /// <returns></returns>
    
    public override int result()
    {
        int value = 1;
        foreach (var e in Input.Values)
        {
            value = value * e.result();
        
        }
        return value;
    }
}




