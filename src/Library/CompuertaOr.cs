namespace Library;
/// <summary>
///  se crea la clase CompuertaOR que hereda de la clase Compuertas
/// </summary>
public class CompuertaOR:Compuertas
{
    /// <summary>
    ///  se crea el constructor de la clase CompuertaOR
    /// </summary>
    /// <param name="name"></param>
    public CompuertaOR(string name):base(name)
    {

    }

    /// <summary>
    ///  se crea el metodo result que calcula el resultado de la compuerta OR
    /// </summary>
    /// <returns></returns>
    public override int result()
    {
        int result = 0;
        foreach (var e in Input)
        {
            if (e.Value.result() == 1)
            {
                result = 1;
            }
            if  (e.Value.result()==0 && result==0)
            {
                result = 0;
            }
        
        }
        return result;
    }


    
}