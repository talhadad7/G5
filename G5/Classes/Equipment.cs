
using G5;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace G5
{
    public class Equipment
    {
        private string itemID;
        private string name;
        private EquipmentCategoryLookup categoryName;
        private EquipmentConditionLookup conditionName;
        private DateTime? lastPurchaseDate;
        private EquipmentLocationLookup locationName;
        private float quantity;
        private float minQuantity;
        private float price;

        // Primary constructor (for new or existing equipment)
        public Equipment(
            string itemID,
            string name,
            EquipmentCategoryLookup categoryName,
            EquipmentConditionLookup conditionName,
            EquipmentLocationLookup locationName,
            float quantity,
            float minQuantity,
            float price,
            DateTime? lastPurchaseDate = null,
            bool isNew = false
        )
        {
            this.itemID = itemID;
            this.name = name;
            this.categoryName = categoryName;
            this.conditionName = conditionName;
            this.locationName = locationName;
            this.quantity = quantity;
            this.minQuantity = minQuantity;
            this.price = price;
            this.lastPurchaseDate = lastPurchaseDate;

            if (isNew)
            {
                CreateEquipment();
                Program.Equimpents.Add(this);
            }
        }

        // CreateEquipment: calls stored procedure to insert into database
        public void CreateEquipment()
        {
            var cmd = new SqlCommand("CreateEquipment")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@itemID", this.itemID);
            cmd.Parameters.AddWithValue("@name", this.name);
            cmd.Parameters.AddWithValue("@categoryName", this.categoryName);
            cmd.Parameters.AddWithValue("@conditionName", this.conditionName);
            cmd.Parameters.AddWithValue("@locationName", this.locationName);
            cmd.Parameters.AddWithValue("@quantity", this.quantity);
            cmd.Parameters.AddWithValue("@minQuantity", this.minQuantity);
            cmd.Parameters.AddWithValue("@price", this.price);
            cmd.Parameters.AddWithValue(
                "@lastPurchaseDate",
                (object)this.lastPurchaseDate ?? DBNull.Value
            );

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public string GetID()
        {
            return this.itemID;
        }
    }
}
