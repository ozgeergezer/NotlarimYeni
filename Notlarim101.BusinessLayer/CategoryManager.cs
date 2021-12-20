using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notlarim101.BusinessLayer.Abstract;
using Notlarim101.DataAccessLayer.EntityFramework;
using Notlarim101.Entity;

namespace Notlarim101.BusinessLayer
{
    public class CategoryManager//:ManagerBase<Category>
    {
        private Repository<Category> rcat = new Repository<Category>();

        public List<Category> GetCategories()
        {
            return rcat.List();
        }

        public Category GetCategoryById(int id)
        {
            return rcat.Find(s => s.Id == id);
        }
        public Category GetCategoryByTitle(string title)
        {
            return rcat.Find(s => s.Title == title);
        }

        //public override int Delete(Category obj)
        //{
        //    NoteManager nm = new NoteManager();

        //    //LikedManager
        //    //CommentManager bu managerlarida new leyecegiz.

        //    //Kategori ile iliskili notlarin silinmesi gerekecek
        //    foreach (Note note in obj.Notes.ToList())
        //    {
        //        //Note ile iliskili Like larin silinmesi
        //        foreach (Liked like in note.Likes.ToList())
        //        {
        //            //lm.delete
        //        }

        //        //Note ile iliskili Comment larin silinmesi
        //        foreach (Comment comment in note.Comments.ToList())
        //        {
        //            //comm.delete
        //        }

        //        //nm.Delete(note);
        //    }
        //    return base.Delete(obj);
        //}
    }
}
