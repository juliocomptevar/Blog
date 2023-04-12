using Blog.Model;
using System;

namespace Blog.Service
{
    public class PostService
    {
        private readonly TabPost _context;
        public PostService(TabPost context)
        {
            _context = context;
        }
        public bool InserirPost(TabPost request)
        {
            try
            {
                var post = new TabPost()
                {
                    IdUsuario = request.IdUsuario,
                    titulo = request.titulo,
                    texto = request.texto,

                };

                _context.TabPost.Add(post);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
