using System.Collections.Generic;
using System.Threading.Tasks;
using TheGospel.Entities;

namespace TheGospel.Contracts
{
    public interface IPostService
    {
        Task<int> CreatePost(TKAPosts tkaposts, string Username);
        Task<int> DeletePost(int Id);
        Task<int> CountPost(string search);
        Task<int> UpdatePost(TKAPosts tkaposts);
        Task<TKAPosts> GetPostById(int Id);
        Task<List<TKAPosts>> ListAllPosts(int skip, int take, string orderBy, string direction, string search);
        //USER POSTS
        Task<List<TKAPosts>> ListAllUserPosts(string username, int skip, int take, string orderBy, string direction, string search);

        /*FOR COMMENT IMPLEMENTATION*/
        Task<int> CreateComment(TKAComments tkacomments, TKAPosts tkaposts, string Username);
        Task<int> DeleteComment(int Id);
        Task<int> CountComment(string search);
        Task<int> UpdateComment(TKAComments tkacomments);
        Task<TKAComments> GetCommentById(int Id);
        Task<List<TKAComments>> ListAllComments();
        Task<List<TKAComments>> ListAllComments(int Id);

        /*FOR EMAIL IMPLEMENTATION*/

        Task<List<TKAComments>> GetUserEmail(int Id);//The email of the user who comments on a post
    }
}
