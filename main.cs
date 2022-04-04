using System; 

public class Program {
    public static void Main(string[] args) {
      #region Tipos de Dados
        
      int numeroInt = 7;
      int maiorNumeroInt = int.MaxValue;
      int menorNumeroInt = int.MinValue;
      long numeroLong = 1234567890;
      long maiorNumeroLong = long.MaxValue;
      long menorNumeroLong = long.MinValue;
      decimal numeroDecimal = 1.70m;
      double numeroDouble = 3.14159265;
      double menorNumeroDouble = double.MinValue;
      double maiorNumeroDouble = double.MaxValue;
      bool verdadeiro = true;
      bool falso = false;
      string nome = "Lauany Reis da Silva";
      char letra = 'L';
      DateTime entradaEmpresa = new DateTime(2021, 1, 1);
      TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;
      var numero = 13;
      
      Console.WriteLine("int: "+ numeroInt);
      Console.WriteLine("int (maior número): "+maiorNumeroInt);
      Console.WriteLine("int (menor número): "+ menorNumeroInt);
      Console.WriteLine("int extendido: "+numeroLong);
      Console.WriteLine("int extendido (maior número): "+ maiorNumeroLong);
      Console.WriteLine("int extendido (menor número): "+ menorNumeroLong);
      Console.WriteLine("decimal: "+ numeroDecimal);
      Console.WriteLine("double: "+ numeroDouble);
      Console.WriteLine("double (menor número): "+ menorNumeroDouble); 
      Console.WriteLine("double (maior número): "+ maiorNumeroDouble); 
      Console.WriteLine("bool: "+ verdadeiro);
      Console.WriteLine("bool: "+ falso);
      Console.WriteLine("string: "+ nome);
      Console.WriteLine("char: "+ letra);
      Console.WriteLine("DateTime: "+ entradaEmpresa);
      Console.WriteLine("TimeSpan: "+ quantoTempoDeEmpresa);
      Console.WriteLine("var: "+ numero);
      
      #endregion
  
      #region Conversões
        
      int notaAluno = 10;
      // Conversão implicita
      double notaAlunoDouble = notaAluno;
      // conversão Explicita
      int numeroDoubleComoInt = (int) notaAlunoDouble;
      // Conversão utilizando Convert
      string notaString = "10";
      int notaConvert = Convert.ToInt32(notaString);
      // Conversão utilizando Parse
      int notaParse = int.Parse(notaString);
  
      if (! int.TryParse(notaString, out int notaTryParse))
      {
        Console.WriteLine("Número em formato inválido.");
      }
          
      #endregion
        
      #region Operadores
      
      // Unários ++, --.
      int numero0perador = 4;
      Console.WriteLine(numero0perador++); // 4
      Console.WriteLine(numero0perador--); // 5
      Console.WriteLine(++numero0perador); // 5
      Console.WriteLine(--numero0perador); // 4
      Console.WriteLine(numero0perador); // 4
      Console.WriteLine(-numero0perador); // -4
      Console.WriteLine(-(-numero0perador)); // 4


      #endregion
        
      Console.Read();
  }
}