using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Role:IdentityRole <int>
    {
        public Role(){}
        public Role(string name, RoleValue roleValue){}
    }
}