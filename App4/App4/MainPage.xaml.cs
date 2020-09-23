using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("OnAppearing");
            List<Element> items = new List<Element>();
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            items.Add(new Element("SUCCESS", "100", "01:01:11", "LH"));
            items.Add(new Element("FAIL", "299", "12:12:12", "RH"));
            items.Add(new Element("FAIL", "199", "15:08:45", "LH"));
            items.Add(new Element("SUCCESS", "188", "16:00:56", "RH"));
            items.Add(new Element("SUCCESS", "1909", "17:08:14", "LH"));
            MyListView.ItemsSource = items;
            //MyListView.ItemTemplate = (DataTemplate) Resources["dataTemplateA"];
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            Debug.WriteLine("OnSizeAllocated");
            base.OnSizeAllocated(width, height); //must be called

            var dataTemplateA = new DataTemplate(() => {
                var grid = new Grid
                {
                    RowDefinitions = {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                    },
                    ColumnDefinitions = {
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                    }
                };

                var label1 = new Label();
                label1.SetBinding(Label.TextProperty, "A");
                grid.Children.Add(label1, 0, 0);


                var label2 = new Label();
                label2.SetBinding(Label.TextProperty, "B");
                grid.Children.Add(label2, 1, 0);


                var label3 = new Label();
                label3.SetBinding(Label.TextProperty, "C");
                grid.Children.Add(label3, 2, 0);


                var label4 = new Label();
                label4.SetBinding(Label.TextProperty, "D");
                grid.Children.Add(label4, 3, 0);

                return new ViewCell { View = grid };
            });

            var dataTemplateB = new DataTemplate(() => {
                var grid = new Grid
                {
                    RowDefinitions = {
                        new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                        new RowDefinition { Height = new GridLength(3, GridUnitType.Star)}
                    },
                    ColumnDefinitions = {
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star )},
                    }
                };

                var label1 = new Label();
                label1.FontSize = 25;
                label1.SetBinding(Label.TextProperty, "A");
                Grid.SetColumnSpan(label1, 3);
                grid.Children.Add(label1, 0, 0);


                var label2 = new Label();
                label2.SetBinding(Label.TextProperty, "B");
                grid.Children.Add(label2, 0, 1);


                var label3 = new Label();
                label3.SetBinding(Label.TextProperty, "C");
                grid.Children.Add(label3, 1, 1);


                var label4 = new Label();
                label4.SetBinding(Label.TextProperty, "D");
                grid.Children.Add(label4, 2, 1);

                return new ViewCell { View = grid };
            });

            Resources = new ResourceDictionary();
            Resources.Add("dataTemplateA", dataTemplateA);
            Resources.Add("dataTemplateB", dataTemplateB);

            MyListView.ItemSelected -= listItemSelected;

            if (height > width)
            {
                try { 
                    MyListView.ItemTemplate = (DataTemplate)Application.Current.Resources["dataTemplateB"];
                    MyListView.ItemSelected += listItemSelected;
                    ListViewStickyHeaderWide.IsVisible = false;
                    ListViewStickyHeaderNarrow.IsVisible = true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            else
            {
                try
                {
                    MyListView.ItemTemplate = (DataTemplate)Application.Current.Resources["dataTemplateA"];
                    ListViewStickyHeaderWide.IsVisible = true;
                    ListViewStickyHeaderNarrow.IsVisible = false;
                }
                catch ( Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }

        }

        private async void listItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if( MyListView.SelectedItem != null)
            {
                var element = (Element)e.SelectedItem;
                ModalPage page = new ModalPage(element.A, element.B, element.C, element.D);
                await Navigation.PushModalAsync(page);
            }

        }


    }

    class Element {

        public String A { get; set; }

        public String B { get; set; }
        
        public String C { get; set; }

        public String D { get; set; }

        public Element(String a, String b, String c, String d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override string ToString()
        {
            return "boogaloo";
        }
    }

}
