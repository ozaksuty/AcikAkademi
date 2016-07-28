using Ders3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Ders3.Views
{
    public partial class Detail : ContentPage
    {
        public Detail(MVAFactory.MVA selected)
        {
            InitializeComponent();

            lblTitle.Text = selected.Title;
            lblDescription.Text = selected.Description;
        }
    }
}
