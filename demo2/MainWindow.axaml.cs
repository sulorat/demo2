using Avalonia.Controls;
using System;

namespace demo2
{
    public partial class MainWindow : Window
    {
        public class ClientPresenter() : Client
        {
            public int ClietnID { get => this.Id; }
            public int ClietnGender {  get => this.Gendercode; }
            public string ClientName { get => this.Firstname; }
            public string ClientLastName { get=>this.Lastname; }
            public string ClientPatronymic { get=>Patronymic; }
            public DateTime? ClientBirthday { get=>Birthday; }
            public string ClientNumberPhone { get=> Phone; }
            public string ClietnEmail { get=>Email; }
            public 

        }

        public MainWindow()
        {

            InitializeComponent();

        }
    }
}