using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PlagiarismChecker.Report;

using Xamarin.Forms;

namespace PlagiarismChecker
{
    public partial class ResultPage : ContentPage
    {
        private ObservableCollection<Result> _result;

        public ResultPage()
        {
            InitializeComponent();

            _result = new ObservableCollection<Result>
            {
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
                new Result{ResultHead = "UNIQUE",Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry."}
            };

            listView.ItemsSource = _result;
        }
    }
}
