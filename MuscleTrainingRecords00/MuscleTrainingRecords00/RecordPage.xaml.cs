using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordPage : ContentPage
    {
        int weight;
        DateTime yyyymmdd;
        private Entry insertEntry;

        public RecordPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            var InsertName = insertEntry.Text;
            RecordsModel.InsertRecords(weight);//試し

  /*var InsertName = insertEntry.Text;
  RecordsModel.insertRecords(InsertName); */
            DisplayAlert("", "保存されました", "OK");


            Navigation.PushAsync(new RecordListPage());
        }

    }

}