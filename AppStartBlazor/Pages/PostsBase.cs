using AppStartBlazor.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Pages
{
    public class PostsBase : ComponentBase
    {
        public IEnumerable<Post> Posts { get; set; }

        public PostsBase()
        {
        }

        private void InitializePosts()
        {
            User usuario = new User { Id = 1, UserName = "Admin", Login = "adm@appstart.com.br" };

            Posts = new List<Post>()
            {
                new Post { Id = 1, Title = "Nova formula para o coronavirus", Excerpt = "Esta formula vai trazer a cura dos infectados", CreationDate = DateTime.Now, CreatorUser = usuario, PublishStatus = PostStatus.Aproved },
                new Post { Id = 2, Title = "Velha formula para o coronavirus", Excerpt = "Esta formula vai trazer a cura dos infectados", CreationDate = DateTime.Now, CreatorUser = usuario, PublishStatus = PostStatus.Aproved }
            };

        }

        protected override Task OnInitializedAsync()
        {
            InitializePosts();
            return base.OnInitializedAsync();
        }

    }
}
