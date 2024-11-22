using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Collections;

namespace OOP2_Project
{
    internal class Product
    {
        public string productType { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int availableQuantity { get; set; }
        public string image { get; set; }
        public string serialKey { get; set; }

        SqlConnection sqlCon = new SqlConnection("Data Source=EFTI\\SQLEXPRESS;Initial Catalog=TitanTechDatabase;Integrated Security=True");

        public bool addProduct(Product product) {
            if (product.GetType() == typeof(Motherboard))
            {
                int quantity;
                Motherboard motherboard = product as Motherboard;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + motherboard.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        motherboard.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE MOTHERBOARD SET FormFactor='" + motherboard.formFactor + "', Pin='" + motherboard.pin + "' WHERE SerialKey= '" + motherboard.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + motherboard.productType + "', Brand='" + motherboard.brand + "', Model='" + motherboard.model + "'," +
                                    " Name='" + motherboard.name + "', Price='" + motherboard.price + "', AvailableQuantity='" + motherboard.availableQuantity + "', " +
                                    "ProductImage='" + motherboard.image + "' WHERE SerialKey='" + motherboard.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }

                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO MOTHERBOARD VALUES('" + motherboard.serialKey + "','" + motherboard.formFactor + "','" + motherboard.pin + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + motherboard.productType + "','" + motherboard.brand + "','" + motherboard.model + "'" +
                            ",'" + motherboard.name + "','" + motherboard.price + "','" + motherboard.availableQuantity + "','" + motherboard.image + "','" + motherboard.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }





            else if (product.GetType() == typeof(Processor))
            {
                int quantity;
                Processor processor = product as Processor;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + processor.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        processor.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE PROCESSOR SET Generation='" + processor.generation + "', Pin='" + processor.pin + "', FloorSpeed='" + processor.floorSpeed + "', CeilingSpeed='" + processor.ceilingSpeed + "',RamGeneration='" + processor.ramGeneration + "' WHERE SerialKey= '" + processor.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + processor.productType + "', Brand='" + processor.brand + "', Model='" + processor.model + "'," +
                                    " Name='" + processor.name + "', Price='" + processor.price + "', AvailableQuantity='" + processor.availableQuantity + "', " +
                                    "ProductImage='" + processor.image + "' WHERE SerialKey='" + processor.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO PROCESSOR VALUES('" + processor.serialKey + "','" + processor.generation + "', '" + processor.pin + "', '" + processor.floorSpeed + "', '" + processor.ceilingSpeed + "', '" + processor.ramGeneration + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + processor.productType + "','" + processor.brand + "','" + processor.model + "'" +
                            ",'" + processor.name + "','" + processor.price + "','" + processor.availableQuantity + "','" + processor.image + "','" + processor.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }










            else if (product.GetType() == typeof(Ram))
            {
                int quantity;
                Ram ram = product as Ram;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + ram.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        ram.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE RAM SET Generation='" + ram.generation + "', BusSpeed='" + ram.busSpeed + "', Memory='" + ram.memory + "' WHERE SerialKey= '" + ram.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + ram.productType + "', Brand='" + ram.brand + "', Model='" + ram.model + "'," +
                                    " Name='" + ram.name + "', Price='" + ram.price + "', AvailableQuantity='" + ram.availableQuantity + "', " +
                                    "ProductImage='" + ram.image + "' WHERE SerialKey='" + ram.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO RAM VALUES('" + ram.serialKey + "','" + ram.generation + "', '" + ram.busSpeed + "', '" + ram.memory + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + ram.productType + "','" + ram.brand + "','" + ram.model + "'" +
                            ",'" + ram.name + "','" + ram.price + "','" + ram.availableQuantity + "','" + ram.image + "','" + ram.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }













            else if (product.GetType() == typeof(PowerSupply))
            {
                int quantity;
                PowerSupply powerSupply = product as PowerSupply;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + powerSupply.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        powerSupply.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE PowerSupply SET FormFactor='" + powerSupply.formFactor + "', Wattage='" + powerSupply.wattage + "', Certification='" + powerSupply.certification + "' WHERE SerialKey= '" + powerSupply.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + powerSupply.productType + "', Brand='" + powerSupply.brand + "', Model='" + powerSupply.model + "'," +
                                    " Name='" + powerSupply.name + "', Price='" + powerSupply.price + "', AvailableQuantity='" + powerSupply.availableQuantity + "', " +
                                    "ProductImage='" + powerSupply.image + "' WHERE SerialKey='" + powerSupply.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO PowerSupply VALUES('" + powerSupply.serialKey + "','" + powerSupply.formFactor + "', '" + powerSupply.wattage + "', '" + powerSupply.certification + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + powerSupply.productType + "','" + powerSupply.brand + "','" + powerSupply.model + "'" +
                            ",'" + powerSupply.name + "','" + powerSupply.price + "','" + powerSupply.availableQuantity + "','" + powerSupply.image + "','" + powerSupply.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }















            else if (product.GetType() == typeof(Casing))
            {
                int quantity;
                Casing casing = product as Casing;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + casing.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        casing.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE CASING SET FormFactor='" + casing.formFactor + "', TotalFanSlot=" + casing.totalFanSlot + ", IncludedFan='" + casing.includedFan + "' WHERE SerialKey= '" + casing.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + casing.productType + "', Brand='" + casing.brand + "', Model='" + casing.model + "'," +
                                    " Name='" + casing.name + "', Price=" + casing.price + ", AvailableQuantity=" + casing.availableQuantity + ", " +
                                    "ProductImage='" + casing.image + "' WHERE SerialKey='" + casing.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO Casing VALUES('" + casing.serialKey + "','" + casing.formFactor + "', '" + casing.totalFanSlot + "', '" + casing.includedFan + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + casing.productType + "','" + casing.brand + "','" + casing.model + "'" +
                            ",'" + casing.name + "','" + casing.price + "','" + casing.availableQuantity + "','" + casing.image + "','" + casing.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }









            else if (product.GetType() == typeof(GraphicsCard))
            {
                int quantity;
                GraphicsCard gpu = product as GraphicsCard;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + gpu.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        gpu.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE GPU SET Distributor='" + gpu.distributor + "', Generation='" + gpu.generation + "', Memory='" + gpu.memory + "', WattageRequirement='" + gpu.wattageRequirement + "' WHERE SerialKey= '" + gpu.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + gpu.productType + "', Brand='" + gpu.brand + "', Model='" + gpu.model + "'," +
                                    " Name='" + gpu.name + "', Price='" + gpu.price + "', AvailableQuantity='" + gpu.availableQuantity + "', " +
                                    "ProductImage='" + gpu.image + "' WHERE SerialKey='" + gpu.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO GPU VALUES('" + gpu.serialKey + "','" + gpu.distributor + "', '" + gpu.generation + "', '" + gpu.memory + "','" + gpu.wattageRequirement + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + gpu.productType + "','" + gpu.distributor + "','" + gpu.model + "'" +
                            ",'" + gpu.name + "','" + gpu.price + "','" + gpu.availableQuantity + "','" + gpu.image + "','" + gpu.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
























            else if (product.GetType() == typeof(Monitor))
            {
                int quantity;
                Monitor monitor = product as Monitor;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + monitor.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        monitor.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE MONITOR SET Resolution='" + monitor.resolution + "', RefreshRate='" + monitor.refreshRate + "', Panel='" + monitor.panel + "', ResponseTime='" + monitor.responseTime + "', ScreenSize='" + monitor.screenSize + "' WHERE SerialKey= '" + monitor.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + monitor.productType + "', Brand='" + monitor.brand + "', Model='" + monitor.model + "'," +
                                    " Name='" + monitor.name + "', Price='" + monitor.price + "', AvailableQuantity='" + monitor.availableQuantity + "', " +
                                    "ProductImage='" + monitor.image + "' WHERE SerialKey='" + monitor.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO MONITOR VALUES('" + monitor.serialKey + "','" + monitor.resolution + "', '" + monitor.refreshRate + "', '" + monitor.panel + "','" + monitor.responseTime + "','" + monitor.screenSize + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + monitor.productType + "','" + monitor.brand + "','" + monitor.model + "'" +
                            ",'" + monitor.name + "','" + monitor.price + "','" + monitor.availableQuantity + "','" + monitor.image + "','" + monitor.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }


























            else if (product.GetType() == typeof(Keyboard))
            {
                int quantity;
                Keyboard keyboard = product as Keyboard;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + keyboard.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        keyboard.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE KEYBOARD SET Type='" + keyboard.type + "', Switch='" + keyboard.keyboardSwitch + "', FormFactor='" + keyboard.formFactor + "' WHERE SerialKey= '" + keyboard.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + keyboard.productType + "', Brand='" + keyboard.brand + "', Model='" + keyboard.model + "'," +
                                    " Name='" + keyboard.name + "', Price='" + keyboard.price + "', AvailableQuantity='" + keyboard.availableQuantity + "', " +
                                    "ProductImage='" + keyboard.image + "' WHERE SerialKey='" + keyboard.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO KEYBOARD VALUES('" + keyboard.serialKey + "','" + keyboard.type + "', '" + keyboard.keyboardSwitch + "', '" + keyboard.formFactor + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + keyboard.productType + "','" + keyboard.brand + "','" + keyboard.model + "'" +
                            ",'" + keyboard.name + "','" + keyboard.price + "','" + keyboard.availableQuantity + "','" + keyboard.image + "','" + keyboard.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }



























            else if (product.GetType() == typeof(Mouse))
            {
                int quantity;
                Mouse mouse = product as Mouse;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + mouse.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        mouse.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE MOUSE SET Type='" + mouse.type + "', Switch='" + mouse.mouseSwitch + "' WHERE SerialKey= '" + mouse.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + mouse.productType + "', Brand='" + mouse.brand + "', Model='" + mouse.model + "'," +
                                    " Name='" + mouse.name + "', Price='" + mouse.price + "', AvailableQuantity='" + mouse.availableQuantity + "', " +
                                    "ProductImage='" + mouse.image + "' WHERE SerialKey='" + mouse.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO MOUSE VALUES('" + mouse.serialKey + "','" + mouse.type + "', '" + mouse.mouseSwitch + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + mouse.productType + "','" + mouse.brand + "','" + mouse.model + "'" +
                            ",'" + mouse.name + "','" + mouse.price + "','" + mouse.availableQuantity + "','" + mouse.image + "','" + mouse.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }





            else if (product.GetType() == typeof(Headphone))
            {
                int quantity;
                Headphone headphone = product as Headphone;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + headphone.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        headphone.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE HEADPHONE SET Type='" + headphone.type + "', PortType='" + headphone.portType + "', Sensitivity='" + headphone.sensitivity + "' WHERE SerialKey= '" + headphone.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + headphone.productType + "', Brand='" + headphone.brand + "', Model='" + headphone.model + "'," +
                                    " Name='" + headphone.name + "', Price='" + headphone.price + "', AvailableQuantity='" + headphone.availableQuantity + "', " +
                                    "ProductImage='" + headphone.image + "' WHERE SerialKey='" + headphone.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO HEADPHONE VALUES('" + headphone.serialKey + "','" + headphone.type + "', '" + headphone.portType + "', '" + headphone.sensitivity + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + headphone.productType + "','" + headphone.brand + "','" + headphone.model + "'" +
                            ",'" + headphone.name + "','" + headphone.price + "','" + headphone.availableQuantity + "','" + headphone.image + "','" + headphone.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }



























            else if (product.GetType() == typeof(Storage))
            {
                int quantity;
                Storage storage = product as Storage;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + storage.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        storage.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE STORAGE SET StorageType='" + storage.storageType + "', Memory='" + storage.memory + "', RPM='" + storage.rpm + "' WHERE SerialKey= '" + storage.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + storage.productType + "', Brand='" + storage.brand + "', Model='" + storage.model + "'," +
                                    " Name='" + storage.name + "', Price='" + storage.price + "', AvailableQuantity='" + storage.availableQuantity + "', " +
                                    "ProductImage='" + storage.image + "' WHERE SerialKey='" + storage.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO STORAGE VALUES('" + storage.serialKey + "','" + storage.storageType + "', '" + storage.memory + "', '" + storage.rpm + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + storage.productType + "','" + storage.brand + "','" + storage.model + "'" +
                            ",'" + storage.name + "','" + storage.price + "','" + storage.availableQuantity + "','" + storage.image + "','" + storage.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }






























            else if (product.GetType() == typeof(CpuCooler))
            {
                int quantity;
                CpuCooler cpuCooler = product as CpuCooler;

                string query = "Select AvailableQuantity from Product WHERE SerialKey='" + cpuCooler.serialKey + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);

                sqlCon.Open();


                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        quantity = reader.GetInt32(0);
                        cpuCooler.availableQuantity += quantity;
                        reader.Close();

                        query = "UPDATE CpuCooler SET CoolerType='" + cpuCooler.coolerType + "', Size='" + cpuCooler.size + "', ProcessorBrand='" + cpuCooler.processorBrand + "', FanSpeed='" + cpuCooler.fanSpeed + "' WHERE SerialKey= '" + cpuCooler.serialKey + "'";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "UPDATE PRODUCT SET ProductType='" + cpuCooler.productType + "', Brand='" + cpuCooler.brand + "', Model='" + cpuCooler.model + "', Name= '"+ cpuCooler.name + "', Price='" + cpuCooler.price + "', AvailableQuantity='" + cpuCooler.availableQuantity + "', ProductImage='" + cpuCooler.image + "' WHERE SerialKey='" + cpuCooler.serialKey + "'";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        query = "INSERT INTO CpuCooler VALUES('" + cpuCooler.serialKey + "','" + cpuCooler.coolerType + "', '" + cpuCooler.size + "', '" + cpuCooler.processorBrand + "','" + cpuCooler.fanSpeed + "')";

                        command = new SqlCommand(query, sqlCon);
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                query = "INSERT INTO PRODUCT VALUES('" + cpuCooler.productType + "','" + cpuCooler.brand + "','" + cpuCooler.model + "'" +
                            ",'" + cpuCooler.name + "','" + cpuCooler.price + "','" + cpuCooler.availableQuantity + "','" + cpuCooler.image + "','" + cpuCooler.serialKey + "')";

                                command = new SqlCommand(query, sqlCon);
                                rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    sqlCon.Close();
                                    return true;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return false;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            else {
                return false;
            }
        
            
        }

        


        
        public DataTable showProductSerial(string serialKey) {
            string query = "SELECT * FROM Product WHERE SerialKey LIKE '" + serialKey + "%'";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showProductType(string pType)
        {
            string query = "";

            if (pType == "Motherboard")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage, P.SerialKey, M.FormFactor, M.Pin FROM Product P INNER JOIN MOTHERBOARD M ON P.SerialKey = M.SerialKey ";
            }
            else if (pType == "Processor")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Generation, K.Pin, K.FloorSpeed, K.CeilingSpeed, K.RamGeneration FROM Product P INNER JOIN Processor K ON P.SerialKey = K.SerialKey ";
            }
            else if (pType == "Ram") {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, R.Generation, R.BusSpeed, R.Memory FROM Product P INNER JOIN Ram R ON P.SerialKey = R.SerialKey ";
            }
            else if (pType == "Power Supply")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, S.FormFactor, S.Wattage, S.Certification FROM Product P INNER JOIN PowerSupply S ON P.SerialKey = S.SerialKey ";
            }
            else if (pType == "Casing")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.FormFactor, C.TotalFanSlot, C.IncludedFan FROM Product P INNER JOIN Casing C ON P.SerialKey = C.SerialKey ";
            }

            else if (pType == "Cpu Cooler")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.CoolerType, C.Size, C.ProcessorBrand, C.FanSpeed FROM Product P INNER JOIN CpuCooler C ON P.SerialKey = C.SerialKey ";
            }
            else if (pType == "Mouse")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, M.Type, M.Switch FROM Product P INNER JOIN MOUSE M ON P.SerialKey = M.SerialKey ";
            }
            else if (pType == "Keyboard")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Type, K.Switch, K.FormFactor FROM Product P INNER JOIN KEYBOARD K ON P.SerialKey = K.SerialKey ";
            }
            else if (pType == "Graphics Card")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, G.Distributor, G.Generation, G.Memory, G.WattageRequirement FROM Product P INNER JOIN GPU G ON P.SerialKey = G.SerialKey ";
            }
            else if (pType == "Monitor")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, M.Resolution, M.RefreshRate, M.Panel, M.ResponseTime, M.ScreenSize FROM Product P INNER JOIN Monitor M ON P.SerialKey = M.SerialKey ";
            }
            else if (pType == "Headphone")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, H.Type, H.PortType, H.Sensitivity FROM Product P INNER JOIN Headphone H ON P.SerialKey = H.SerialKey ";
            }
            else if (pType == "Storage")
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, S.StorageType, S.Memory, S.RPM FROM Product P INNER JOIN Storage S ON P.SerialKey = S.SerialKey ";
            }




            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showAllProduct()
        {
            string query = "SELECT * FROM Product";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }



        public DataTable showAllStockoutProduct() {
            string query = "SELECT * FROM PRODUCT WHERE AvailableQuantity=0";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }

        public DataTable showStockoutProductSerial(string serialKey) {
            string query = "SELECT * FROM PRODUCT WHERE AvailableQuantity=0 AND SerialKey Like '"+serialKey+"%'";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }



        public DataTable showAllAvailableProduct()
        {
            string query = "SELECT * FROM PRODUCT WHERE AvailableQuantity>0";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showAvailableProductSerial(string serialKey)
        {
            string query = "SELECT * FROM PRODUCT WHERE AvailableQuantity>0 AND SerialKey Like '" + serialKey + "%'";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }



        public int getCustomerID() { 
            string query = "Select CustomerID From Customer where Email='"+TitanTech.cEmail+"'";

            sqlCon.Open();

            SqlCommand command = new SqlCommand(query, sqlCon);

            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int s;
                    reader.Read();
                    s = reader.GetInt32(0);
                    reader.Close();
                    sqlCon.Close();
                    return s;
                }
                else {
                    reader.Close();
                    sqlCon.Close();
                    return 0;
                }
            }
            else {
                sqlCon.Close();
                return 0;
            }
        }

        public bool orderProduct(string pType, string pName, int pPrice, string pSerial, int aQuantity, int oQuantity, string address) {
            string query;
            if (getCustomerID() != 0)
            {
                query = "INSERT INTO [ORDER] VALUES('" + pType + "','" + pName + "',"+pPrice+"," + oQuantity + ","+(oQuantity*pPrice)+",'" + pSerial + "','" + address + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "'," + getCustomerID() + ")";

                sqlCon.Open();
                SqlCommand command = new SqlCommand (query, sqlCon);

                if (sqlCon.State == ConnectionState.Open)
                {
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        query = "UPDATE PRODUCT SET AvailableQuantity=" + (aQuantity - oQuantity) + " WHERE SerialKey='"+pSerial+"'";
                        command = new SqlCommand(query, sqlCon);
                        rows = command.ExecuteNonQuery();
                        sqlCon.Close();
                        return true;
                    }
                    else
                    {
                        sqlCon.Close(); return false;
                    }
                }
                else { 
                    sqlCon.Close (); return false;
                }
            
            }
            else {
                return false;
            }
            
        }





        public bool removeProduct(string serialKey, string productType) {
            string query = "DELETE FROM PRODUCT WHERE SerialKey ='" + serialKey + "'";
            SqlCommand command = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    query = "DELETE FROM " + productType + " WHERE SerialKey ='" + serialKey + "'";
                    command = new SqlCommand(query, sqlCon);
                    rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        sqlCon.Close();
                        return true;
                    }
                    else
                    {
                        sqlCon.Close();
                        return false;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return false;
                }
            }
            else {
                sqlCon.Close();
                return false;
            }

        }





        // PC BUILDER ------------------------------------------------------------------------------------------------------------------------------------
        public DataTable showMotherboard(string casingSerial, string processorSerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            string formFactor = "";
            string pin = "";
            if (casingSerial != "" && processorSerial == "")
            {
                query = "SELECT FormFactor FROM Casing Where SerialKey='" + casingSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        formFactor = reader.GetString(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage, P.SerialKey, M.FormFactor, M.Pin FROM Product P INNER JOIN MOTHERBOARD M ON P.SerialKey = M.SerialKey Where M.FormFactor = '" + formFactor + "'";

                        sqlCon.Open();
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }
            else if (casingSerial == "" && processorSerial != "")
            {
                query = "SELECT Pin FROM Processor Where SerialKey='" + processorSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        pin = reader.GetString(0);
                        reader.Close();

                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage, P.SerialKey, M.FormFactor, M.Pin FROM Product P INNER JOIN MOTHERBOARD M ON P.SerialKey = M.SerialKey Where M.pin='" + pin + "'";


                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
            else if (casingSerial != "" && processorSerial != "")
            {
                query = "SELECT Pin FROM Processor Where SerialKey='" + processorSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        pin = reader.GetString(0);
                        reader.Close();

                        query = "SELECT FormFactor FROM Casing Where SerialKey='" + casingSerial + "'";
                        command = new SqlCommand(query, sqlCon);
                        sqlCon.Open();

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                formFactor = reader.GetString(0);
                                reader.Close();

                                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage, P.SerialKey, M.FormFactor, M.Pin FROM Product P INNER JOIN MOTHERBOARD M ON P.SerialKey = M.SerialKey Where M.FormFactor = '" + formFactor + "' AND M.pin='" + pin + "'";

                                sqlCon.Open();
                                if (sqlCon.State == ConnectionState.Open)
                                {
                                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                                    sqlDa.Fill(dtbl);
                                    sqlCon.Close();
                                    return dtbl;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return null;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return null;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }

            else {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage, P.SerialKey, M.FormFactor, M.Pin FROM Product P INNER JOIN MOTHERBOARD M ON P.SerialKey = M.SerialKey ";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------








        public DataTable showProcessor(string motherboardSerial, string ramSerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            string ramGeneration = "";
            string pin = "";
            if (motherboardSerial != "" && ramSerial == "")
            {
                query = "SELECT Pin FROM Motherboard Where SerialKey='" + motherboardSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        pin = reader.GetString(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Generation, K.Pin, K.FloorSpeed, K.CeilingSpeed, K.RamGeneration FROM Product P INNER JOIN Processor K ON P.SerialKey = K.SerialKey Where K.Pin='"+pin+"'";

                     
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }
            else if (motherboardSerial == "" && ramSerial != "")
            {
                query = "SELECT Generation FROM Ram Where SerialKey='" + ramSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        ramGeneration = reader.GetString(0);
                        reader.Close();

                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Generation, K.Pin, K.FloorSpeed, K.CeilingSpeed, K.RamGeneration FROM Product P INNER JOIN Processor K ON P.SerialKey = K.SerialKey Where K.RamGeneration='"+ramGeneration+"'";

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
            else if (motherboardSerial != "" && ramSerial != "")
            {
                query = "SELECT Pin FROM Motherboard Where SerialKey='" + motherboardSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        pin = reader.GetString(0);
                        reader.Close();

                        query = "SELECT Generation FROM Ram Where SerialKey='" + ramSerial + "'";
                        command = new SqlCommand(query, sqlCon);
                        sqlCon.Open();

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                ramGeneration = reader.GetString(0);
                                reader.Close();

                                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Generation, K.Pin, K.FloorSpeed, K.CeilingSpeed, K.RamGeneration FROM Product P INNER JOIN Processor K ON P.SerialKey = K.SerialKey Where K.RamGeneration='"+ramGeneration+"' AND K.Pin = '"+pin+"'";

                                sqlCon.Open();
                                if (sqlCon.State == ConnectionState.Open)
                                {
                                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                                    sqlDa.Fill(dtbl);
                                    sqlCon.Close();
                                    return dtbl;
                                }
                                else
                                {
                                    sqlCon.Close();
                                    return null;
                                }
                            }
                            else
                            {
                                sqlCon.Close();
                                return null;
                            }
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }

            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Generation, K.Pin, K.FloorSpeed, K.CeilingSpeed, K.RamGeneration FROM Product P INNER JOIN Processor K ON P.SerialKey = K.SerialKey";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }













        public DataTable showRam(string processorSerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            string generation = "";
            if (processorSerial != "")  // CODES NEEDS TO BE CHECKED HERE ( WHAT IF MOTHERBOARD IS SELECTED AND PROCESSOR ISN'T)----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            {
                query = "SELECT RamGeneration FROM Processor Where SerialKey='" + processorSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        generation = reader.GetString(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, R.Generation, R.BusSpeed, R.Memory FROM Product P INNER JOIN Ram R ON P.SerialKey = R.SerialKey Where R.Generation='"+generation+"'";

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }
            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, R.Generation, R.BusSpeed, R.Memory FROM Product P INNER JOIN Ram R ON P.SerialKey = R.SerialKey";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }

















        public DataTable showCpuCooler(string processorSerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            string brand = "";
            if (processorSerial != "")
            {
                query = "SELECT Brand FROM Product Where SerialKey='" + processorSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        brand = reader.GetString(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.CoolerType, C.Size, C.ProcessorBrand, C.FanSpeed FROM Product P INNER JOIN CpuCooler C ON P.SerialKey = C.SerialKey Where C.ProcessorBrand = '"+brand+"'";
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }
            
            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.CoolerType, C.Size, C.ProcessorBrand, C.FanSpeed FROM Product P INNER JOIN CpuCooler C ON P.SerialKey = C.SerialKey ";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }







        public DataTable showCasing(string motherboardSerial)
        {
            DataTable dtbl = new DataTable();
            string formFactor = "";
            string query = "";
            if (motherboardSerial != "")
            {
                query = "SELECT FormFactor FROM Motherboard Where SerialKey='" + motherboardSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        formFactor = reader.GetString(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.FormFactor, C.TotalFanSlot, C.IncludedFan FROM Product P INNER JOIN Casing C ON P.SerialKey = C.SerialKey Where C.FormFactor = '"+formFactor+"'";

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }
            
            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, C.FormFactor, C.TotalFanSlot, C.IncludedFan FROM Product P INNER JOIN Casing C ON P.SerialKey = C.SerialKey ";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }



        public DataTable showGraphicsCard(string powerSupplySerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            int wattage = 0;
            if (powerSupplySerial != "")
            {
                query = "SELECT Wattage FROM PowerSupply Where SerialKey='" + powerSupplySerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        wattage = reader.GetInt32(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, G.Distributor, G.Generation, G.Memory, G.WattageRequirement FROM Product P INNER JOIN GPU G ON P.SerialKey = G.SerialKey Where WattageRequirement<='"+(wattage-150)+"'";

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }

            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, G.Distributor, G.Generation, G.Memory, G.WattageRequirement FROM Product P INNER JOIN GPU G ON P.SerialKey = G.SerialKey";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }

        public DataTable showPowerSupply(string graphicsCardSerial)
        {
            DataTable dtbl = new DataTable();
            string query;
            int wattageRequirement = 0;
            if (graphicsCardSerial != "")
            {
                query = "SELECT WattageRequirement FROM GPU Where SerialKey='" + graphicsCardSerial + "'";
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        wattageRequirement = reader.GetInt32(0);
                        reader.Close();
                        query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, S.FormFactor, S.Wattage, S.Certification FROM Product P INNER JOIN PowerSupply S ON P.SerialKey = S.SerialKey Where S.Wattage >= '"+(wattageRequirement+150)+"'";

       
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                            sqlDa.Fill(dtbl);
                            sqlCon.Close();
                            return dtbl;
                        }
                        else
                        {
                            sqlCon.Close();
                            return null;
                        }
                    }
                    else
                    {
                        sqlCon.Close();
                        return null;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }

            }

            else
            {
                query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, S.FormFactor, S.Wattage, S.Certification FROM Product P INNER JOIN PowerSupply S ON P.SerialKey = S.SerialKey ";
                dtbl = new DataTable();
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
        }

        public DataTable showMonitor() {
            string query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, M.Resolution, M.RefreshRate, M.Panel, M.ResponseTime, M.ScreenSize FROM Product P INNER JOIN Monitor M ON P.SerialKey = M.SerialKey";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }

        public DataTable showStorage()
        {
            string query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, S.StorageType, S.Memory, S.RPM FROM Product P INNER JOIN Storage S ON P.SerialKey = S.SerialKey ";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }

        public DataTable showMouse()
        {
            string query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, M.Type, M.Switch FROM Product P INNER JOIN MOUSE M ON P.SerialKey = M.SerialKey";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showKeyboard()
        {
            string query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, K.Type, K.Switch, K.FormFactor FROM Product P INNER JOIN KEYBOARD K ON P.SerialKey = K.SerialKey ";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showHeadphone()
        {
            string query = "SELECT P.ProductType, P.Name, P.Brand, P.Model, P.Price, P.AvailableQuantity, P.ProductImage,P.SerialKey, H.Type, H.PortType, H.Sensitivity FROM Product P INNER JOIN Headphone H ON P.SerialKey = H.SerialKey ";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }




        public bool orderPCB(string motherboardSerial, string processorSerial, string ram1Serial,
            string ram2Serial, string ram3Serial, string ram4Serial, string powerSupplySerial, string graphicsCardSerial,
            string cpuCoolerSerial, string storageSeiral, string monitorSerial, string casingSerial, string keyboardSerial, string mouseSerial,
            string headphoneSerial)
        {

            string query = "INSERT INTO OrderPCB VALUES('" + motherboardSerial + "','" + processorSerial + "','" + ram1Serial + "','" + ram2Serial + "','" + ram3Serial + "','" + ram4Serial + "','" + powerSupplySerial + "','" + graphicsCardSerial + "','" + cpuCoolerSerial + "','" + storageSeiral + "','" + monitorSerial + "','" + casingSerial + "','" + keyboardSerial + "','" + mouseSerial + "','" + headphoneSerial + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "'," + getCustomerID() + ")";

            SqlCommand command = new SqlCommand(query, sqlCon);
            sqlCon.Open();

            if (sqlCon.State == ConnectionState.Open)
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    sqlCon.Close();
                    return true;
                }
                else
                {
                    sqlCon.Close();
                    return false;
                }

            }
            else
            {
                sqlCon.Close();
                return false;
            }
        }
    }
}
