using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Covid19
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0,y1=0,y2=0,y3=0,y4=0,y5=0;

        public BlankPage2()
        {
            this.InitializeComponent();
        }

        private void question1(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

              
            if (rb.Name == "Yes1")
            {

                x1 = 1;

                y1 = 1;
            }
            else
            {
                x1 = 0;
                y1 = 1;
            }

            //    sel.Text = "You chose: " + rb.GroupName + ": " + rb.Name;


        }

        private void question2(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Name == "Yes2")
            {

                x2 = 1;
                y2 = 1;
            }
            else
            {
                x2 = 0;
                y2 = 1;
            }

            //    sel.Text = "You chose: " + rb.GroupName + ": " + rb.Name;


        }

        private void question3(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Name == "Yes3")
            {

                x3 = 1;
                y3 = 1;
            }
            else
            {
                x3 = 0;
                y3 = 1;

            }

            //    sel.Text = "You chose: " + rb.GroupName + ": " + rb.Name;


        }


        private void question4(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Name == "Yes4")
            {

                x4 = 1;
                y4 = 1;
            }
            else
            {
                x4 = 0;
                y4 = 1;
            }

            //    sel.Text = "You chose: " + rb.GroupName + ": " + rb.Name;


        }


        private void question5(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Name == "Yes5")
            {

                x5 = 1;
                y5 = 1;
            }
            else
            {
                x5 = 0;
                y5 = 1;
            }

            //    sel.Text = "You chose: " + rb.GroupName + ": " + rb.Name;


        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //  MySomeMethod();
            if (y1 == 0 || y2 == 0 || y3 == 0 || y4==0 || y5==0)
            {

                MySomeMethod("Please Answer all the Questions...!","Error");
            
            }
            else if (x1== 1 && x2==1 && x5==1 && x3==0 && x4==0)
            {
                MySomeMethod("You should contact a doctor immediately.Your doctor will decide if you need to be tested for COVID - 19.Before your appointment, please call ahead and tell them about your symptoms so they can prepare for your visit .You should stay home and away from other people for the duration of your symptoms unless otherwise advised by a doctor.", "Contact a doctor");

            }
            else if (x1 == 1 && x2 == 1 && x5 == 1 && x3==1 && x4==1)
            {
                MySomeMethod("You should contact a doctor immediately.Your doctor will decide if you need to be tested for COVID - 19.Before your appointment, please call ahead and tell them about your symptoms so they can prepare for your visit .You should stay home and away from other people for the duration of your symptoms unless otherwise advised by a doctor.", "Covid-19 Test Required");
            }
            else
            {
                MySomeMethod("Good Luck  , it seems like that you are safe. Take care of your health and follow guidlines.","Good Result");
            }
        }

        private async void MySomeMethod(String text,String title)
        {
            ContentDialog dlg = new ContentDialog()
            {
                Title = title,
                Content = text,
                CloseButtonText = "Ok"
                
            };

            
            await dlg.ShowAsync();
        }

        
    }
}
