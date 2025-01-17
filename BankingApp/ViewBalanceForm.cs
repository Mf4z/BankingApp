﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class ViewBalanceForm : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int userId;
        public ViewBalanceForm()
        {
            InitializeComponent();
            server = "13.39.79.161";
            database = "bankapp";
            uid = "epita";
            password = "Secret@123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public ViewBalanceForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            server = "13.39.79.161";
            database = "bankapp";
            uid = "epita";
            password = "Secret@123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            getBalance();
        }

        private void getBalance()
        {
            connection.Open();
            string query = "SELECT Balance FROM Account WHERE accountUser = " + this.userId;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                float balance = dataReader.GetFloat("balance");
                label1.Text = "Available Balance: " + balance;
            }
            connection.Close();
        }
    }
}
