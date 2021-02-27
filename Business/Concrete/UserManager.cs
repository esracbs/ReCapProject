using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult("Kullanıcı eklendi");
        }


        public IResult Delete(User user)
        {
            _userdal.Delete(user);

            return new SuccessResult("Kullanıcı silindi");
        }

        

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult("kullanıcılar güncellendi");
        }

        IDataResult<List<User>> IUserService.GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), "kullaıcılar listelendi");
        }
    }
}
