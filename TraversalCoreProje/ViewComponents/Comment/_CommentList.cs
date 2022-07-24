using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)// dışardan bir id alması şart çünkü bu id göre işlem yapıcam 
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }

    }
}
