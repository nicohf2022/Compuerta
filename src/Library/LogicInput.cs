
namespace Library;
/// <summary>
///  se crea la clase LogicInput que implementa la interfaz Iinput
/// </summary>

public class LogicInput : IInput
{
   
    /// <summary>
    /// se crea el constructor de la clase LogicInput
    /// </summary>
    public LogicInput(int value)
    {
        this.Value = value;
    }
    
    /// <summary>
    /// 
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// se crea el metodo result que retorna el valor de la compuerta
    /// </summary>
    public int result()
    {
        return this.Value;
    }

}
