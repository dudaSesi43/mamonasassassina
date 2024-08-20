namespace mamonasassassinas.Modelos;
public class Despache : ModeloPai
{
    string NomeDespache;
    string Usuario;
    int Senha;
    string Assinaturadocliente;
    
    public void SetNomeDespache(string NomeDespache)
    {
     this.NomeDespache = NomeDespache;
    }
    public string GetNomeDespache()
    {
        return NomeDespache;
    }
    public void SetUsuario(string Usuario)
    {
        this.Usuario = Usuario;
    }
    public string GetUsuario()
    {
        return Usuario;
    }
    public void SetSenha(int Senha)
    {
        this.Senha = Senha;
    }
    public int  GetSenha()
    {
        return Senha;
    }
    public void SetAssinaturadocliente(string Assinaturadocliente)
    {
     this.Assinaturadocliente = Assinaturadocliente;   
    }
 public string GetAssinaturadocliente()
 {
        return Assinaturadocliente;
    }
    }

    
