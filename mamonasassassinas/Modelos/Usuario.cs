namespace mamonasassassinas.Modelos;
public class Usuario : ModeloPai
{
     string NomeUsuario;
    int Senha;
    string Criarlogin;
    public void SetNomeUsuario(string NomeDespache)
    {
     this.NomeDespache = NomeDespache;
    }
    public string GetNomeUsuario()
    {
        return NomeUsuario;
    }
    public void SetUsuario(string Usuario)
    {
        this.Usuario = Usuario;
    }
    public string GetUsuario()
    {
        return Usuario;
}
 public void SetSenha(string NomeDespache)
    {
     this.Senha = SetSenha;
    }
    public int GetSenha()
    {
        return Senha;
    }
    public void SetSenha(string Usuario)
    {
        this.Senha = Senha;
    }
    public string GetSenha()
    {
        return Senha;
}
 public void SetCriarlogin(string NomeDespache)
    {
     this.Senha = SetCriarlogin;
    }
    public string GetCriarlogin()
    {
        return Criarlogin;
    }
    public void SetCriarlogin(string Usuario)
    {
        this.Criarlogin = Criarlogin;
    }
    public string GetCriarlogin()
    {
        return Criarlogin;
}

}
