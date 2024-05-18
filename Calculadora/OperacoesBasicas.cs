namespace Calculadora
{
    public class OperacoesBasicas
    {
        private int _qtdLimiteHistorico;
        private List<string> _historico;

        public OperacoesBasicas()
        {
            _qtdLimiteHistorico = 3;
            _historico = new();
        }

        public OperacoesBasicas(int qtdLimiteHistorico)
        {
            _qtdLimiteHistorico = qtdLimiteHistorico;
            _historico = new();
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            _historico.Insert(0, $"{a} + {b} = {resultado}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            _historico.Insert(0, $"{a} - {b} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            _historico.Insert(0, $"{a} * {b} = {resultado}");
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            int resultado = a / b;
            _historico.Insert(0, $"{a} / {b} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(_qtdLimiteHistorico, _historico.Count - _qtdLimiteHistorico);
            return _historico;
        }
    }
}
