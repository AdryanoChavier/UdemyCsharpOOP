using System.Security.AccessControl;

namespace ProjetoStringBuilder.Entities;

public class Post
{
    public DateTime Moment { get; set; }
    public string Title { get; set;}
    public string Content { get; set;}
    public int Like { get; set; }
    public List<Comment> Comments{ get; set; } = new List<Comment>();
    public Post(){

    }
    public Post(DateTime moment, string title,string content,int like){
        Moment = moment;
        Title = title;
        Content = content;
        Like = like;
    }
    public void AddComment(Comment comment){
        Comments.Add(comment);
    }
    public void RemoveComment(Comment comment){
        Comments.Remove(comment);
    }

}
