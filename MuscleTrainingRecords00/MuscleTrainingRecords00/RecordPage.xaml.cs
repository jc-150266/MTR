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
        private Entry m_weightEntry;
        private Entry LegEntry;
        private Entry SetEntry;
        private Entry m_date;
        DateTime yyyymmdd;
        private Entry insertEntry;

        public RecordPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            
            var M_weight = m_weightEntry.Text;
            var M_leg = LegEntry.Text;
            var M_set = SetEntry.Text;
            //var yyyymmdd = m_date.Text;
            RecordsModel.InsertRecords(M_weight);//試し

             /*var InsertName = insertEntry.Text;
             RecordsModel.insertRecords(InsertName); */
            DisplayAlert("", "保存されました", "OK");


            Navigation.PushAsync(new RecordListPage());
        }
    }

}