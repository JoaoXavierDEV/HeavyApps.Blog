namespace HeavyApps.Blog.Domain.Model;
public class Autor : EntityBase
{
    public virtual string Nome { get; set; }
    public virtual string Email { get; set; }
    public virtual string Biografia { get; set; }
    public virtual List<Post> Posts { get; set; } = new List<Post>();

    public Autor()
    {

    }

    public Autor(string nome, string email, string biografia)
    {
        Nome = nome;
        Email = email;
        Biografia = biografia;
    }

    public Autor(string nome, string email, string biografia, List<Post> posts)
    {
        Nome = nome;
        Email = email;
        Biografia = biografia;
        Posts = posts;
    }
}
