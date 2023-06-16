<<<<<<< HEAD
﻿namespace DataTlayer;
using BusinessModel;
/// <summary>
/// storing the inmemory of List of users
/// </summary>
public class DataSource
{
    public static List<User> datatable = new List<User>();
    internal DataSource()
    {
    }
    public void AddUser(User user)
    {
        datatable.Add(user);
    }
    public bool Login(User user)
    {
        User findUserLogin = datatable.Find(findUserLogin => findUserLogin.UserName == user.UserName);
        if (findUserLogin != null)
        {
            if (findUserLogin.password == user.password)
            {
                return true;
            }
        }
        return false;
    }



    public bool Register(User user)
    {
        User u = DataSource.datatable.Find(u => u.UserName == user.UserName);
        if (u != null)
        {
            return false;
        }

        datatable.Add(user);
        return true;
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTlayer
{
    /// <summary>
    /// storing the inmemory of List of users
    /// </summary>
    public class DataSource
    {
        public static List<List<string>>datatable=new List<List<string>>();

    }
}
>>>>>>> d094bc957d6bdcd590f18d6f9ba3ea5eb290ab28
