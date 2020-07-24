using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingtipToys.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WingtipToys.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            //数据库context创建
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            //提供角色管理
            var roleStore = new RoleStore<IdentityRole>(context);

            //公开与角色相关的API，在roleStore上建立 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.

            //创建用户管理
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "Admin@cs.com",
                Email = "Admin@cs.com"
            };
            IdUserResult = userMgr.Create(appUser, "Admin@cs.com");

         
            if (!userMgr.IsInRole(userMgr.FindByEmail("Admin@cs.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("Admin@cs.com").Id, "canEdit");
            }
        }
    }
}