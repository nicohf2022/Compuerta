using System;
using System.Collections.Generic;






namespace Library;

/// <summary>
/// se crea la clase abstracta  Compuertas que implementa la interfaz IInput
/// </summary>
public abstract class  Compuertas: IInput

{   
   /// <summary>
   ///  se crea el constructor de la clase Compuertas y se lanza la excepcion si el nombre es nulo
   /// </summary>
   /// <param name="name"></param>
    public Compuertas(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }
        
        this.Name = name;
        this.Input = new Dictionary<string, IInput>(); //se crea un diccionario de entradas

    }
      
      /// <summary>
      /// se crea la propiedad Name
      /// </summary>
      /// <value></value>
      public string Name { get; set; }
      /// <summary>
      ///  se crea un diccionario de entradas
      /// </summary>
      /// <value></value>
      
      public Dictionary<string, IInput> Input { get; set; }


    

    /// <summary>
    /// se crea el metodo AddInput que agrega una entrada al diccionario
    /// </summary>
    public void AddInput(string name, IInput value)
    {
        if (Input.ContainsKey(name))
        {
            Input[name] = value;
        }
        else
        {
            Input.Add(name, value);
        }
    }         
    
/// <summary>
///  se crea el metodo result que retorna el resultado de la compuerta
/// </summary>
/// <returns></returns>
public abstract int result();

}       




    
    
