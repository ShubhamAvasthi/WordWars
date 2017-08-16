using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//■

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WordWars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int intresponse = 0;
        TextBlock[,] TB_Array = new TextBlock[10, 10];
        TextBlock[] RTB_Array = new TextBlock[10];
        static int n = 0;
        public MainPage()
        {
            this.InitializeComponent();
            char[,] TBC = new char[10, 10];
            TB_Array[0, 0] = textBlock00;
            TB_Array[0, 1] = textBlock01;
            TB_Array[0, 2] = textBlock02;
            TB_Array[0, 3] = textBlock03;
            TB_Array[0, 4] = textBlock04;
            TB_Array[0, 5] = textBlock05;
            TB_Array[0, 6] = textBlock06;
            TB_Array[0, 7] = textBlock07;
            TB_Array[0, 8] = textBlock08;
            TB_Array[0, 9] = textBlock09;
            TB_Array[1, 0] = textBlock10;
            TB_Array[1, 1] = textBlock11;
            TB_Array[1, 2] = textBlock12;
            TB_Array[1, 3] = textBlock13;
            TB_Array[1, 4] = textBlock14;
            TB_Array[1, 5] = textBlock15;
            TB_Array[1, 6] = textBlock16;
            TB_Array[1, 7] = textBlock17;
            TB_Array[1, 8] = textBlock18;
            TB_Array[1, 9] = textBlock19;
            TB_Array[2, 0] = textBlock20;
            TB_Array[2, 1] = textBlock21;
            TB_Array[2, 2] = textBlock22;
            TB_Array[2, 3] = textBlock23;
            TB_Array[2, 4] = textBlock24;
            TB_Array[2, 5] = textBlock25;
            TB_Array[2, 6] = textBlock26;
            TB_Array[2, 7] = textBlock27;
            TB_Array[2, 8] = textBlock28;
            TB_Array[2, 9] = textBlock29;
            TB_Array[3, 0] = textBlock30;
            TB_Array[3, 1] = textBlock31;
            TB_Array[3, 2] = textBlock32;
            TB_Array[3, 3] = textBlock33;
            TB_Array[3, 4] = textBlock34;
            TB_Array[3, 5] = textBlock35;
            TB_Array[3, 6] = textBlock36;
            TB_Array[3, 7] = textBlock37;
            TB_Array[3, 8] = textBlock38;
            TB_Array[3, 9] = textBlock39;
            TB_Array[4, 0] = textBlock40;
            TB_Array[4, 1] = textBlock41;
            TB_Array[4, 2] = textBlock42;
            TB_Array[4, 3] = textBlock43;
            TB_Array[4, 4] = textBlock44;
            TB_Array[4, 5] = textBlock45;
            TB_Array[4, 6] = textBlock46;
            TB_Array[4, 7] = textBlock47;
            TB_Array[4, 8] = textBlock48;
            TB_Array[4, 9] = textBlock49;
            TB_Array[5, 0] = textBlock50;
            TB_Array[5, 1] = textBlock51;
            TB_Array[5, 2] = textBlock52;
            TB_Array[5, 3] = textBlock53;
            TB_Array[5, 4] = textBlock54;
            TB_Array[5, 5] = textBlock55;
            TB_Array[5, 6] = textBlock56;
            TB_Array[5, 7] = textBlock57;
            TB_Array[5, 8] = textBlock58;
            TB_Array[5, 9] = textBlock59;
            TB_Array[6, 0] = textBlock60;
            TB_Array[6, 1] = textBlock61;
            TB_Array[6, 2] = textBlock62;
            TB_Array[6, 3] = textBlock63;
            TB_Array[6, 4] = textBlock64;
            TB_Array[6, 5] = textBlock65;
            TB_Array[6, 6] = textBlock66;
            TB_Array[6, 7] = textBlock67;
            TB_Array[6, 8] = textBlock68;
            TB_Array[6, 9] = textBlock69;
            TB_Array[7, 0] = textBlock70;
            TB_Array[7, 1] = textBlock71;
            TB_Array[7, 2] = textBlock72;
            TB_Array[7, 3] = textBlock73;
            TB_Array[7, 4] = textBlock74;
            TB_Array[7, 5] = textBlock75;
            TB_Array[7, 6] = textBlock76;
            TB_Array[7, 7] = textBlock77;
            TB_Array[7, 8] = textBlock78;
            TB_Array[7, 9] = textBlock79;
            TB_Array[8, 0] = textBlock80;
            TB_Array[8, 1] = textBlock81;
            TB_Array[8, 2] = textBlock82;
            TB_Array[8, 3] = textBlock83;
            TB_Array[8, 4] = textBlock84;
            TB_Array[8, 5] = textBlock85;
            TB_Array[8, 6] = textBlock86;
            TB_Array[8, 7] = textBlock87;
            TB_Array[8, 8] = textBlock88;
            TB_Array[8, 9] = textBlock89;
            TB_Array[9, 0] = textBlock90;
            TB_Array[9, 1] = textBlock91;
            TB_Array[9, 2] = textBlock92;
            TB_Array[9, 3] = textBlock93;
            TB_Array[9, 4] = textBlock94;
            TB_Array[9, 5] = textBlock95;
            TB_Array[9, 6] = textBlock96;
            TB_Array[9, 7] = textBlock97;
            TB_Array[9, 8] = textBlock98;
            TB_Array[9, 9] = textBlock99;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    TB_Array[i, j].Foreground = new SolidColorBrush(Colors.Brown);
                    TB_Array[i, j].AllowDrop = true;
                    TB_Array[i, j].Drop += textBlock_Drop;
                    TB_Array[i, j].DragOver += textBlock_DragOver;
                    TB_Array[i, j].Text = "■";
                    TBC[i, j] = '■';
                }
            }
            for (int i = 0; i < 5; i++)
                DragGrid.RowDefinitions.Add(new RowDefinition());
            for (int i = 0; i < 2; i++)
                DragGrid.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Viewbox v = new Viewbox();
                    v.HorizontalAlignment = HorizontalAlignment.Stretch;
                    v.VerticalAlignment = VerticalAlignment.Stretch;
                    Border b = new Border();
                    b.BorderBrush = new SolidColorBrush(Colors.Black);
                    b.BorderThickness = new Thickness(3);
                    Thickness margin = b.Margin;
                    margin.Left = 1;
                    margin.Right = 1;
                    margin.Top = 1;
                    margin.Bottom = 1;
                    b.Margin = margin;
                    b.HorizontalAlignment = HorizontalAlignment.Stretch;
                    b.VerticalAlignment = VerticalAlignment.Stretch;
                    Grid.SetColumn(b, j);
                    Grid.SetRow(b, i);
                    TextBlock a = new TextBlock();
                    a.Foreground = new SolidColorBrush(Colors.DarkBlue);
                    a.Text = "■";
                    a.FontWeight = FontWeights.Bold;
                    a.HorizontalAlignment = HorizontalAlignment.Stretch;
                    a.VerticalAlignment = VerticalAlignment.Stretch;
                    a.CanDrag = true;
                    a.DragStarting += textBlock_DragStarting;
                    v.Child = a;
                    b.Child = v;
                    DragGrid.Children.Add(b);
                    RTB_Array[2 * i + j] = a;
                }
            }
            int[] freqar = new int[26] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            int fsum = 0;
            for (int i = 0; i < 26; i++)
                fsum += freqar[i];
            for (int j = 0; j < 10; j++)
            {
                Task.Delay(100).Wait();
                int cumsum = 0;
                Random rand = new Random();
                int m = rand.Next(1, fsum);
                for (int k = 0; k < 26; k++)
                {
                    cumsum += freqar[k];
                    if (cumsum >= m - 1)
                    {
                        //RTB_Array[j].Text = k.ToString();
                        RTB_Array[j].Text = ((char)('A' + k)).ToString();
                        break;
                    }
                }
            }

            int curP = 1;
            //this.Frame.Navigate(typeof(MainPage));
            Loaded += MainPage_Loaded;



            //WordResponse("changed");
            //while (intresponse.CompareTo(0)==0) ;
            //textBlockL2.Text += " " + intresponse.ToString();
            //
        }

        public static async void Func(string word)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("app_id", @"a09e2ac0");
                client.DefaultRequestHeaders.Add("app_key", @"7ecaaa6ac7f04302dbdf690443422009");

                var response = await client.GetAsync("https://od-api.oxforddictionaries.com:443/api/v1/inflections/en/" + word);
                //if (response.IsSuccessStatusCode)
                //{
                //Do your thing
                //}
                manip(((int)response.StatusCode));
            }
        }

        public static void manip(int a)
        {
            intresponse = a;
        }

        public static int WordResponse(string word)
        {
            intresponse = 0;
            Func(word);
            

            return intresponse;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            n++;
            if(n==1)
            this.Frame.Navigate(typeof(FirstPage));
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            Grandparent.ColumnDefinitions[0].Width = GridLength.Auto;
            Grandparent.ColumnDefinitions[1].Width = new Windows.UI.Xaml.GridLength(0);
        }

        private void textBlock_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            args.Data.SetText(((TextBlock)sender).Text);
            args.Data.Properties.Add("rootTB",(sender));
        }
        
        private async void textBlock_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = await e.DataView.GetTextAsync();



            int[] freqar = new int[26] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            int fsum = 0;
            for (int i = 0; i < 26; i++)
                fsum += freqar[i];
            
                int cumsum = 0;
                Random rand = new Random();
                int m = rand.Next(1, fsum);
                for (int k = 0; k < 26; k++)
                {
                    cumsum += freqar[k];
                    if (cumsum >= m - 1)
                    {
                    //RTB_Array[j].Text = k.ToString();
                    ((TextBlock)(e.DataView.Properties["rootTB"])).Text = ((char)('A' + k)).ToString();
                        break;
                    }
                }




            //((TextBlock)(e.DataView.Properties["rootTB"])).Text = "■";
            if (textBlockL1.Text == "P1")
                textBlockL1.Text = "P2";
            else
                textBlockL1.Text = "P1";
        }

        private void textBlock_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;
        }
    }
}
