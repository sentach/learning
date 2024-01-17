using Ejercicio001Lib;

namespace Ejercicio001.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var value = SumarDigitos.Sumar(0);
        Assert.Equal(0, value);
    }

    [Fact] 
    public void Test2() 
    {
        var value = SumarDigitos.Sumar(16);
        Assert.Equal(7, value);
    }

    [Fact]
    public void Test3()
    {
        var value = SumarDigitos.Sumar(1283);
        Assert.Equal(5, value);
    }

    [Fact]
    public void Test4()
    {
        var value = SumarDigitos.Sumar(99765);
        Assert.Equal(9, value);
    }

    [Fact]
    public void Test5() 
    {
        var value = SumarDigitos.Sumar(493193);
        Assert.Equal(2, value);
    }

    [Fact]
    public void Test6()
    {
        var value = SumarDigitos.Sumar(10);
        Assert.Equal(1, value);
    }
}