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
        List<string> entriesInCountries = new List<string>();
        List<string> entriesInClients = new List<string>();
        string[] countriesEntriesArray;
        string[] clientsEntriesArray;

        public Form1()
        {
            InitializeComponent();
            comboBoxClientList.Items.AddRange(ListItemsFromDB("wrongclients"));
            comboBoxCountryList.Items.AddRange(ListItemsFromDB("wrongcountry"));
        }

        private void comboBoxClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxDBContents.Items.AddRange(ListEntriesPerItem("wrongclients", comboBoxClientList.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("err");
            }

            Console.WriteLine(comboBoxClientList.SelectedItem.ToString());
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
                default:
                    string[] a = {};
                    return a;
            }
        }

        public string[] ListEntriesPerItem (string table, string item)
        {
            var connectionString = "mongodb://192.168.42.85:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("local");
            var filter = new BsonDocument();
            switch (table)
            {
                case "wrongclients":
                    entriesInClients.Clear();
                    var clientCollection = db.GetCollection<BsonDocument>(table);
                    var jsonQuery = "{'seniorstaff.name' : { $exists: true }}";
                    BsonDocument docu = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(jsonQuery);
                    using (var cursor = clientCollection.Find(filter).ToCursor())
                    {
                        while (cursor.MoveNext())
                        {
                            foreach (var doc in cursor.Current)
                            {
                                try
                                {
                                    entriesInClients.Add(doc["name.entry"].ToString());
                                    clientsEntriesArray = entriesInClients.ToArray();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("error");
                                }

                            }
                        }
                    }
                    return clientsEntriesArray;
                case "wrongcountry":
                    entriesInCountries.Clear();
                    var countryCollection = db.GetCollection<BsonDocument>(table);
                    using (var cursor = countryCollection.Find(filter).ToCursor())
                    {
                        while (cursor.MoveNext())
                        {
                            foreach (var doc in cursor.Current)
                            {
                                entriesInCountries.Add(doc["Name.entry"].ToString());
                                countriesEntriesArray = entriesInCountries.ToArray();
                            }
                        }
                    }
                    return countriesEntriesArray;
                default:
                    string[] a = { };
                    return a;
            }
        }
    }
}
