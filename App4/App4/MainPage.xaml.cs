using System;
using System.Collections.Generic;
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
            List<Element> items = new List<Element>();
            items.Add(new Element("red", "dog", "one", "cabbage"));
            items.Add(new Element("blue", "cat", "two", "carrot"));
            items.Add(new Element("blue", "cat", "three", "carrot"));
            items.Add(new Element("blue", "cat", "four", "carrot"));
            items.Add(new Element("blue", "cat", "five", "carrot"));
            MyListView.ItemsSource = items;

            var dataTemplateA = new DataTemplate(() => {
                var grid = new Grid {
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
                grid.Children.Add( label1, 0, 0);


                var label2 = new Label();
                label2.SetBinding(Label.TextProperty, "B");
                grid.Children.Add(label2, 1, 0);


                var label3 = new Label();
                label3.SetBinding(Label.TextProperty, "C");
                grid.Children.Add(label3, 2, 0);


                var label4 = new Label();
                label4.SetBinding(Label.TextProperty, "D");
                grid.Children.Add(label4, 3, 0);

                return new ViewCell{ View = grid };
            });
            Resources = new ResourceDictionary();

            Resources.Add("dataTemplateA", dataTemplateA);

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

            Resources.Add("dataTemplateB", dataTemplateB);

            MyListView.ItemTemplate = (DataTemplate) Resources["dataTemplateA"];
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (height > width)
            {
                try { 
                    MyListView.ItemTemplate = (DataTemplate)Resources["dataTemplateB"];
                }
                catch (Exception e)
                {

                }
            }
            else
            {
                try
                {
                    MyListView.ItemTemplate = (DataTemplate)Resources["dataTemplateA"];
                } catch ( Exception e)
                {

                }
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
    }

}
