namespace ExemploColecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($" Índice {i}, Valor: {lista[i]}");
            }
        }
    }
}