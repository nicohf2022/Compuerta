using System;
using System.Collections.Generic;
using NUnit.Framework;
using Library;

namespace LibraryTests;
/// <summary>
/// se crea la clase Tests.
/// </summary>
public class Tests
{
    LogicInput input1 = new LogicInput(1);
    LogicInput input2 = new LogicInput(0);
    
    /// <summary>
    /// se crea el metodo TestAnd que prueba la compuerta and y la excepcion que se lanza si no tiene 2 entradas.
    /// </summary>
    [Test]
    public void TestAnd()
    {  
        CompuertasAnd and1 = new CompuertasAnd("AND-1");
        and1.Input.Add("A", input1);
        and1.Input.Add("B", input2);
        Assert.AreEqual(0,and1.result());
        try
        {
            and1.Input.Add("C", input1);
        }
        catch (ExeptionCant e)
        {
            Assert.AreEqual("La compuerta no tiene 2 entradas",e.Message);
        }
    }
    /// <summary>
    /// se crea el metodo TestOr que prueba la compuerta or y la excepcion que se lanza si no tiene 2 entradas.
    /// </summary>
    [Test]
    public void TestOr()
    {
        CompuertaOR or1 = new CompuertaOR("OR-1");
        or1.Input.Add("A", input1);
        or1.Input.Add("B", input2);
        Assert.AreEqual(1,or1.result());
        try
        {
            or1.Input.Add("C", input1);
        }
        catch (ExeptionCant e)
        {
            Assert.AreEqual("La compuerta no tiene 2 entradas",e.Message);
        }
    }
    /// <summary>
    /// se crea el metodo TestNot que prueba la compuerta not y la excepcion que se lanza si no tiene 1 entrada.
    /// </summary>
    [Test]
     public void TestNot()
    {
        CompuertaNot not1 = new CompuertaNot("NOT-1");
        not1.Input.Add("A", input1);
        Assert.AreEqual(0,not1.result());
        try
        {
            not1.Input.Add("B", input1);
        }
        catch (ExeptionCant e)
        {
            Assert.AreEqual("La compuerta no tiene 1 entrada",e.Message);
        }
    }
    
}