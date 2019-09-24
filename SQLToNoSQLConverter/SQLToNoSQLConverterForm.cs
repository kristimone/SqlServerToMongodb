using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SQLToNoSQLConverter
{
    public partial class SQLToNoSQLConverterForm : Form
    {
        SqlConnection conn;
        String connectionString;
        SqlCommand objcmd;
        MongoClient client;
        IMongoDatabase database;
        string mongodbconnectionstring = "mongodb://localhost:27017";
        string mongodb = "alphawebtest";

        public SQLToNoSQLConverterForm()
        {
            InitializeComponent();
            client = new MongoClient(mongodbconnectionstring);
            database = client.GetDatabase(mongodb);

            tbConnectionString.Text = @"Server=KRISTI-PC\alpha;Database=webinf;Trusted_Connection=True;";
        }


        private void convertItems(String table)
        {
            var coll = database.GetCollection<BsonDocument>(table);
            tbProgressLog.Text += "Started processing table " + table + "\r\n";
            connectionString = tbConnectionString.Text;
            using (conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM " + table;

                using(objcmd = new SqlCommand(query, conn))
                {
                    database.DropCollection(table);
                    conn.Open();
                    SqlDataReader objReader = objcmd.ExecuteReader();
                    List<BsonDocument> bsonlist = new List<BsonDocument>(1000);
                    while (objReader.Read())
                    {
                        BsonDocument objBson = new BsonDocument();
                        for (int j = 0; j < objReader.FieldCount; j++)
                        {
                            //CHECK TYPE OF ALL COLUMN NAMES SO THAT WE CAN STORE ALL RECORDS IN COLLECTION "DATATYPE WISE"
                            if (objReader[j].GetType() == typeof(String))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), objReader[j].ToString()));
                            }
                            else if ((objReader[j].GetType() == typeof(Int32)))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonValue.Create(objReader.GetInt32(j))));
                            }
                            else if (objReader[j].GetType() == typeof(float))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonValue.Create(objReader.GetFloat(j))));
                            }
                            else if (objReader[j].GetType() == typeof(DateTime))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonValue.Create(objReader.GetDateTime(j))));
                            }
                            else if (objReader[j].GetType() == typeof(Boolean))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonValue.Create(objReader.GetBoolean(j))));
                            }
                            else if (objReader[j].GetType() == typeof(DBNull))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonNull.Value));
                            }
                            else if (objReader[j].GetType() == typeof(Byte))
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), BsonValue.Create(objReader.GetByte(j))));
                            }
                            else
                            {
                                objBson.Add(new BsonElement(objReader.GetName(j), objReader[j].ToString()));
                            }
                        }

                        bsonlist.Add(objBson);
                    }
                    coll = database.GetCollection<BsonDocument>(table);
                    coll.InsertMany(bsonlist);
                    bsonlist.RemoveRange(0, bsonlist.Count);
                }
                }
            tbProgressLog.Text += "Finishing migrating table " + table + "\r\n";
        }

        private void btnConvertAllTables_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = tbConnectionString.Text;
                conn = new SqlConnection(connectionString);
                conn.Open();
                DataTable tables = conn.GetSchema("Tables");
                foreach (DataRow row in tables.Rows)
                {
                    String tablename = row[2].ToString();
                    convertItems(tablename);
                }
                tbProgressLog.Text += "Database converted\r\n";
            }

            catch
            {
                MessageBox.Show("An error has occurred. Please verify that the connection string is correct.");
            }
        }

        private void btnConvertTable_Click(object sender, EventArgs e)
        {
            try
            {
                convertItems(tbTable.Text);
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please verify that the connection string and table name are correct.");
            }
        }
    }
}
