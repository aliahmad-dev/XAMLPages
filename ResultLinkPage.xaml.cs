using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PlagiarismChecker.Report;

using Xamarin.Forms;

namespace PlagiarismChecker
{
    public partial class ResultLinkPage : ContentPage
    {
        private ObservableCollection<ResultLink> _resultlink;

        public ResultLinkPage()
        {
            InitializeComponent();

            _resultlink = new ObservableCollection<ResultLink>
            {
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" },
                new ResultLink{Link=@"https://material-ui.com/style/color/",ParsentAge="13%" }
            };

            listView.ItemsSource = _resultlink;


        }
    }
}
