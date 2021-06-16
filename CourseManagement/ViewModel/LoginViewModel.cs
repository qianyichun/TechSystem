using CourseManagement.Common;
using CourseManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CourseManagement.ViewModel
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }
        public LoginModel LoginModel { get; set; }
        public LoginViewModel()
        {
            this.LoginModel = new LoginModel();
            LoginModel.UserName = "yuchen";
            this.CloseWindowCommand = new CommandBase();
            this.CloseWindowCommand.DoExecute = new Action<object>(o =>
            {
                (o as Window).Close();
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>(o => { return true; });
        }
    }
}
