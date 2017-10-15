using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using RestSharp;

namespace Weather
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            string baseUrl = @"https://api.darksky.net/"; // базовая урла

            string secretKey = "91cc249bb42cee705027d5fe014a58e9";

            RestClient client = new RestClient(baseUrl);

            double latitude;
            double longitude;

            var successParseLatitude = Double.TryParse(latitudeTextBox.Text, out latitude);
            var successParseLongitude = Double.TryParse(longitudeTextBox.Text, out longitude);

            try
            {
                if (successParseLatitude && successParseLongitude)
                {
                    if (latitude >= 0 && latitude <= 90 && longitude >= 0 && longitude <= 180)
                    {
                        RestRequest request =
                            new RestRequest(@"forecast/" + secretKey + "/" + latitude + "," + longitude);

                        request.AddParameter("units", "si"); // параметр отображения погоды в цельсиях

                        var result = client.Execute<RootObject>(request); // выполнение запроса

                        RootObject resultData = result.Data; // класс-обертка 

                        if (result.StatusCode == HttpStatusCode.OK)
                        {
                            temperature.Text = resultData.currently.temperature.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Запрос не может завершиться успешно!", "Ошибка соединения",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Значение параметров не входят в интервалы допустимых значений!",
                            "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректные значения широты и долготы!", "Ошибка ввода", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message + ";");
            }
        }
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9\.]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void latitudeTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void longitudeTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }

    //Генерация классов была выполнена через json2csharp (generate c# classes from json)
    public class Currently
    {
        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public int precipIntensity { get; set; }
        public int precipProbability { get; set; }
        public double temperature { get; set; }
        public double apparentTemperature { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public int windBearing { get; set; }
        public double cloudCover { get; set; }
        public int uvIndex { get; set; }
        public double ozone { get; set; }
    }

    public class RootObject
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public Currently currently { get; set; }
        public int offset { get; set; }
    }
}
