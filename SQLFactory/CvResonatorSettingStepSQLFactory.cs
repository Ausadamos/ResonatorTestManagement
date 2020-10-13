using ResonatorTestManagement.Property;

namespace ResonatorTestManagement.SQLFactory
{
    public class CvResonatorSettingStepSQLFactory
    {
        string tableName = TableName.DB_RESONATOR_SETTING_STEP;


        public string SearchByPurchaseId(CvResonatorSettingStepProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                             inuse = 1
                             AND PURCHASE_ID = 'dataItem.PURCHASE_ID'
                             ORDER BY step_number";

            sql = sql.Replace("tableName", tableName);
            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);

            return sql;
        }

        public string SearchMaxStepByPurchaseId(CvResonatorSettingStepProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                             inuse = 1
                             AND PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                             ORDER BY step_number DESC LIMIT 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);


            return sql;
        }

        public string SearchByPurchaseIdAndStepNo(CvResonatorSettingStepProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                             inuse = 1
                             AND PURCHASE_ID = 'dataItem.PURCHASE_ID'
                             AND STEP_NUMBER = 'dataItem.STEP_NUMBER'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.STEP_NUMBER", dataItem.STEP_NUMBER);

            return sql;
        }

        public string Delete(CvResonatorSettingStepProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID'
                             AND inuse = 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            return sql;

        }

        public string Insert(CvResonatorSettingStepProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , PURCHASE_ID
                                        , STEP_NUMBER
                                        , VOLTAGE
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , USER_CREATE
                                        , INUSE
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.PURCHASE_ID'
                                        , 'dataItem.STEP_NUMBER'
                                        , 'dataItem.VOLTAGE'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.USER_CREATE'
                                        , 1


                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.STEP_NUMBER", dataItem.STEP_NUMBER);
            sql = sql.Replace("dataItem.VOLTAGE", dataItem.VOLTAGE);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);



            return sql;

        }

    }
}