using System;
using System.Collections.Generic;
using Library;
/// <summary>
/// se crea la clase program
/// </summary>
public class program 
{   
    /// <summary>
    /// programa principal
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        
        try
        {
        CompuertasAnd and1 = new CompuertasAnd("AND_1");
        IInput firstInput = new LogicInput(0);
        IInput secondInput = new LogicInput(1);
        and1.Input.Add("A", firstInput);
        and1.Input.Add("B", secondInput);

        CompuertaOR or2 = new CompuertaOR("OR_2");
        IInput thirdInput = new LogicInput(1);
        or2.Input.Add("C", thirdInput);
        or2.Input.Add(and1.Name, and1);

        CompuertaNot not3 = new CompuertaNot("NOT_3");
        not3.Input.Add(or2.Name, or2);

        Console.WriteLine("El resultado final es: " + not3.result());
        }

        catch(ArgumentNullException)
        {
            Console.WriteLine("El nombre de la compuerta no es valido");

        }
        catch (ExeptionCant e)
        {
            Console.WriteLine(e.Message);
        }
         catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


