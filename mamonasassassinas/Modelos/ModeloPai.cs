namespace mamonasassassinas.Modelos;
public partial class ModeloPai : ContentPage
{
    string nome;
    int Id;
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetId(int id)
    {
        this.Id = id;
    }
    public int GetId()
    {
        return Id;
    }

}
