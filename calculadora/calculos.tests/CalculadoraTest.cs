using Xunit;

namespace calculos.tests;

using calculos;

public class CalculadoraTest
{
  [Fact]
  public void Soma_DeveRetornarOValorCorreto()
  {
    Calculadora c = new Calculadora();
    var resultado = c.Soma(10, 20);
    Assert.Equal(30, resultado);
  }

  [Fact]
  public void Subtracao_DeveRetornarOValorCorreto()
  {
    Calculadora c = new Calculadora();
    var resultado = c.Subtracao(20, 10);
    //Verifica se o resultado é igual a 10
    Assert.Equal(10, resultado);
  }

  [Fact]
  public void Divisao_DeveRetornarOValorCorreto()
  {
    Calculadora c = new Calculadora();
    var resultado = c.Divisao(100, 10);
    //Verifica se o resultado é igual a 10
    Assert.Equal(10, resultado);
  }

  [Fact]
  public void Multiplicao_DeveRetornarOValorCorreto()
  {
    Calculadora c = new Calculadora();
    var resultado = c.Multiplicao(5, 2);
    //Verifica se o resultado é igual a 10
    Assert.Equal(10, resultado);
  }

}