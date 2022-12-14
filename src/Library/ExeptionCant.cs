using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// se crea la clase ExeptionCant.
/// </summary>
public class ExeptionCant : Exception
{
    /// <summary>
    /// se crea el constructor de la clase ExeptionCant.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public ExeptionCant(string message) : base(message)
    {
        
    }
}
