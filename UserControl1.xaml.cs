using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace $safeprojectname$
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            onload();
        }

        #region Userdictionary
        //create Userdictionary
        private Dictionary<string, string> UsersDictionary = new Dictionary<string, string>();
        private void onload()
        {


            UsersDictionary.Add("admin", "1");
            UsersDictionary.Add("tugba", "12");
            UsersDictionary.Add("engin", "123");
            UsersDictionary.Add("ahmet", "1234");
            UsersDictionary.Add("esra", "12345");
        }
        #endregion
        #region button login
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Değerleritextbox ve passwordboxdan aldım    
            string value = username.Text;
            string sifre = pasword.Password;
            //ilk olarak user boşmu inceledik
            if (username.Text != "")
            {
                //kullanıcı varmı kontrolünü burda yaptık ilk if de 
                if (UsersDictionary.ContainsKey(value))
                {
                    //passwor boşmu inceledik
                    if (pasword.Password != "")
                    {
                        // kullanıcı şifresi doğrumu inceledik
                        if (sifre == UsersDictionary[value])
                        {
                            sonuc.Content = "şifre ve kullnıcı ismi doğrudur";
                        }
                        else
                        {
                            sonuc.Content = "şifrenizi kontrol ediniz";
                        }
                    }
                    else
                    {
                        sonuc.Content = "lütfen şifrenizi giriniz";
                    }
                }

                else
                {
                    sonuc.Content = "Malesef Böyle bir KUllanıcı yoktur";
                }
            }
            else
            {
                sonuc.Content = " Bütün Alanları doldurunuz";
            }

        }
        #endregion

        
    }
}
