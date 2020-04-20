using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace laba4_uchebka
{
	
	public partial class Form1 : Form
	{
		public string g;
		public Form1()
		{
			InitializeComponent();
			//блокировка ввода данных с клавиатуры в комбо бокс
			comboBoxForCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxForHosp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxForPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			using (var connect = new NpgsqlConnection("host = localhost; username = postgres; password = 1; database = postgres"))
			{
				connect.Open();				

				DataSet MyTable = new DataSet();

				//DataTable people = new DataTable("select firstname, secondname from people", "namesurname");
				
				//DataColumn combinedColumn = new DataColumn("FIO", typeof(string));
				//combinedColumn.Expression = "[firstname] + ' ' + [secondname] ";
				//people.Columns.Add(combinedColumn);
				//MyTable.Tables.Add(people);

				


				var command = new NpgsqlCommand("select city_id, name from cities;", connect);
				var command1 = new NpgsqlCommand("select id_hospital, hospital_name, c_id from hospitals;", connect);
				var command2 = new NpgsqlCommand("select id_people,firstname, secondname, h_id from people", connect);

				var adapter = new NpgsqlDataAdapter(command);
				var adapter1 = new NpgsqlDataAdapter(command1);
				var adapter2 = new NpgsqlDataAdapter(command2);

				adapter.Fill(MyTable, "Cities");
				adapter1.Fill(MyTable, "Hospitals");
				adapter2.Fill(MyTable, "People");

				DataRelation relation1 = MyTable.Relations.Add("CitiesHos",
				  MyTable.Tables["cities"].Columns["city_id"],
				   MyTable.Tables["hospitals"].Columns["c_id"]);

				DataRelation relation2 = MyTable.Relations.Add("HospitalsPeople",
					MyTable.Tables["hospitals"].Columns["id_hospital"],
					MyTable.Tables["people"].Columns["h_id"]);


				//MyTable.Relations.Add(relation1);
				//MyTable.Relations.Add(relation2);

				comboBoxForCity.DataSource = MyTable;
				comboBoxForCity.DisplayMember = "cities.name";



				comboBoxForHosp.DataSource = MyTable;
				comboBoxForHosp.DisplayMember = "cities.CitiesHos.hospital_name";

				comboBoxForPeople.DataSource = MyTable;
				comboBoxForPeople.DisplayMember = "cities.CitiesHos.HospitalsPeople.secondname";
			


			}

		}


		private void comboBoxForCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			 g = comboBoxForCity.Text;
			label1.Text = g;
		


		}
	}
}
