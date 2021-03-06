﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStorePlatform.Models;

namespace OnlineStorePlatform.Controllers
{
    public class MySQLController : DatabaseController
	{
		public User getUser(String identifier)
		{
			OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
			DB_User DBuser = (
							from u in db.DB_Users
							where u.DB_Username == identifier
							|| u.DB_Email == identifier
							select (u)
						).FirstOrDefault();
			User user = null;
			if (DBuser == null)
				return null;
			if (DBuser.DB_Type == 0) user = new Adminstrator(DBuser);
			else if (DBuser.DB_Type == 1) user = new NormalUser(DBuser);
			else if (DBuser.DB_Type == 2) user = new StoreOwner(DBuser);
			return user;
		}
		public List<User> getAllUsers()
		{
			OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
			List<DB_User> DB_users = (from u in db.DB_Users
									  select u).ToList<DB_User>();
			List<User> users = new List<User>();
			if (DB_users.Count == 0)
				return null;
			for (int i = 0; i < DB_users.Count; i++)
			{
				if (DB_users[i].DB_Type == 0) users.Add(new Adminstrator(DB_users[i]));
				else if (DB_users[i].DB_Type == 1) users.Add(new NormalUser(DB_users[i]));
				else if (DB_users[i].DB_Type == 2) users.Add(new StoreOwner(DB_users[i]));
			}
			return users;
		}
		public bool addUser(User user)
		{
			OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
			DB_User u = new DB_User();
			u.DB_Fullname = user.fullname;
			u.DB_Username = user.username;
			u.DB_Password = user.password;
			u.DB_Email = user.email;
			u.DB_Gender = user.gender;
			u.DB_Age = user.age;
			if (user.GetType().Name == "Adminstrator") u.DB_Type = 0;
			else if (user.GetType().Name == "StoreOwner") u.DB_Type = 1;
			else if (user.GetType().Name == "NormalUser") u.DB_Type = 2;
			db.DB_Users.InsertOnSubmit(u);
			db.SubmitChanges();
			return true;
		}

        public bool deleteUser(User user)
        {
            OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
            DB_User DBuser = (
                            from u in db.DB_Users
                            where u.DB_Username == user.username
                            || u.DB_Email == user.email
                            select (u)
                        ).FirstOrDefault();
            if (DBuser == null)
                return false;
            db.DB_Users.DeleteOnSubmit(DBuser);
            db.SubmitChanges();
            return true;
        }
    }
}
