using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StylesExamp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Person> objPersonsList = new List<Person>();
        public MainPage()
        {
            InitializeComponent();

            bindPersonsList();

            etSearchName.TextChanged += EtSearchName_TextChanged;

        }

        private void EtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var personsData = (from a in objPersonsList where a.PersonName.Contains(e.NewTextValue.ToString()) select a).ToList();
            lbxPersonsList.ItemsSource = personsData;
        }

        private void bindPersonsList()
        {
            objPersonsList.Add(new Person { PersonName = "Suresh", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Naresh", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Mahesh", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Chiranjeevi", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Venkatesh", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Balakrishna", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Balu", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "venu", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Banu", PersonAddress = "Andhrapradesh" });
            objPersonsList.Add(new Person { PersonName = "Nagarjuna", PersonAddress = "Andhrapradesh" });

            lbxPersonsList.ItemsSource = objPersonsList;
        }
    }
}
