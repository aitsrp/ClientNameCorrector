using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ClientNameCorrector
{
    public partial class Form1 : Form
    {
        List<string> countriesInDB = new List<string>();
        List<string> clientsInDB = new List<string>();
        string[] countriesArray;
        string[] clientsArray;

        public Form1()
        {
            InitializeComponent();
            comboBoxClientList.Items.AddRange(ListItemsFromDB("wrongclients"));
            comboBoxCountryList.Items.AddRange(ListItemsFromDB("wrongcountry"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string[] ListItemsFromDB(string table)
        {
            var connectionString = "mongodb://192.168.42.85:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("local");
            var filter = new BsonDocument();
            switch (table)
            {
                case "wrongclients":
                    clientsInDB.Clear();
                    var clientCollection = db.GetCollection<BsonDocument>(table);
                    using (var cursor = clientCollection.Find(filter).ToCursor())
                    {
                        while (cursor.MoveNext())
                        {
                            foreach (var doc in cursor.Current)
                            {
                                clientsInDB.Add(doc["name"].ToString());
                                clientsArray = clientsInDB.ToArray();
                            }
                            //for reading
                            foreach (string c in clientsInDB)
                            {
                                Console.WriteLine("clientsInDB: " + c);
                            }
                        }
                        Console.WriteLine("Number of clients: " + clientsInDB.Count);//count the number of items in list
                    }
                    return clientsArray;
                    break;
                case "wrongcountry":
                    countriesInDB.Clear();
                    var countryCollection = db.GetCollection<BsonDocument>(table);
                    using (var cursor = countryCollection.Find(filter).ToCursor())
                    {
                        while (cursor.MoveNext())
                        {
                            foreach (var doc in cursor.Current)
                            {
                                countriesInDB.Add(doc["Name"].ToString());
                                countriesArray = countriesInDB.ToArray();
                            }
                            //for reading
                            foreach (string c in countriesInDB)
                            {
                                Console.WriteLine("countriesInDB: " + c);
                            }
                        }
                        Console.WriteLine("Number of countries: " + countriesInDB.Count);//count the number of items in list
                    }
                    return countriesArray;
                    break;
                default:
                    string[] a = {};
                    return a;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
