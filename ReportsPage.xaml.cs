using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PlagiarismChecker.Report;

using Xamarin.Forms;

namespace PlagiarismChecker
{
    public partial class ReportsPage : ContentPage
    {
        public ObservableCollection<Reports> _report;
        public ReportsPage()
        {
            InitializeComponent();

            _report = new ObservableCollection<Reports>
            {
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"},
                new Reports{Date=DateTime.Now,
                Documents="Lorem Ipsum is simply dummy text of theprinting and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s".Substring(0,50),
                Orignality="80 %"}
            };

            listView.ItemsSource = _report;
        }
    }
}
