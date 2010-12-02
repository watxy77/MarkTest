using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HumanResources.Customer;
using HumanResources.Order;
using HumanResources.Base;
using HumanResources.Users;
using HumanResources.Candidate;
using HumanResources.Dictionary;

namespace HumanResources
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
