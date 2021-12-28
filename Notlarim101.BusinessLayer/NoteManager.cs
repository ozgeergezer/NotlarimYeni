using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notlarim101.BusinessLayer.Abstract;
using Notlarim101.Core.DataAccess;
using Notlarim101.DataAccessLayer.EntityFramework;
using Notlarim101.Entity;
using Notlarim101.Entity.Messages;

namespace Notlarim101.BusinessLayer
{
    public class NoteManager : ManagerBase<Note>
    {
        BusinessLayerResult<Note> res = new BusinessLayerResult<Note>();

        //    public List<Note> GetAllNotes()
        //    {
        //        return rnote.List();
        //    }

        public new BusinessLayerResult<NotlarimUser> Insert(NotlarimUser data)
        {
            Note user = Find(s => s.ModifiedUsername == data.ModifiedUsername || s.ModifiedOn == data.ModifiedOn);
            res.Result = data;

            if (user != null)
            {
                if (user.ModifiedUsername == data.ModifiedUsername)
                {
                    res.AddError(ErrorMessageCode.UsernameAlreadyExist, "Kullanici adi kayitli");
                }

                if (user.Email == data.Email)
                {
                    res.AddError(ErrorMessageCode.EmailalreadyExist, "Email kayitli");
                }
                //throw new Exception("Kayitli kullanici yada e-posta adresi");
            }
            else
            {
                res.Result.ProfileImageFilename = "user1.png";
                res.Result.ActivateGuid = Guid.NewGuid();

                if (base.Insert(res.Result) == 0)
                {
                    res.AddError(ErrorMessageCode.UserCouldNotInserted, "Kullanici eklenemedi");
                }
            }

            return res;
        }

    }
}
