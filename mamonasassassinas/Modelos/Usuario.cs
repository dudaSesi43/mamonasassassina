namespace mamonasassassinas.Modelos;
public class Usuario : ModeloPai
{
     string NomeUsuario;
    int Senha;
    string Criarlogin;
    public void SetNomeUsuario(string NomeUsuario)
    {
     this.NomeUsuario = NomeUsuario;
    }
    public string GetNomeUsuario()
    {
        return NomeUsuario;
    }
    
 public void SetSenha( int Senha)
    {
     this.Senha = Senha;
    }
    public int GetSenha()
    {
        return Senha;
    }
    
 public void SetCriarlogin(string SetCriarlogin)
    {
     String. Criarlogin;
    }
    public string GetCriarlogin()
    {
        return Criarlogin;
    }
}
