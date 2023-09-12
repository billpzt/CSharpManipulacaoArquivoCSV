namespace ArquivoCSV {
    internal class Program {
        static void Main(string[] args) {
            LerArquivo();
        }

        private static void LerArquivo() {
            const String nomeArquivo = "notas.csv";
            const String diretorio = @"C:\Users\william.piazzetta\Documents\BackEnd\FundamentosCsharp";

            String caminho = Path.Combine(diretorio, nomeArquivo);
            if (!File.Exists(caminho)) {
                Console.WriteLine("Erro: Arquivo não existe");
            }
            try {
                using (var arquivo = new StreamReader(caminho)) { // Abertura do arquivo
                    String linha = arquivo.ReadLine();
                    while (linha != null) { // Testa o final do arquivo - EOF
                        String[] campos = linha.Split(";");
                        Aluno aluno = new Aluno(campos[0], double.Parse(campos[1]), double.Parse(campos[2]), double.Parse(campos[3]));
                        Console.WriteLine(aluno);
                        linha = arquivo.ReadLine();
                    }
                }
            }
            catch {
                Console.WriteLine("Erro!");
            }
        }
    }
}