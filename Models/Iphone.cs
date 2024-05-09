namespace DesafioPOO.Models
{
  public class Iphone : Smartphone
  {

    public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
    {
      Numero = numero;
      Modelo = modelo;
      IMEI = imei;
      Memoria = memoria;
    }

    public override void MostrarDados()
    {
      Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória: {Memoria}");
    }
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone...");
    }
  }
}