using ResonatorTestManagement.Property;

namespace ResonatorTestManagement.SQLFactory
{
    public class CvResonatorSettingSQLFactory
    {
        string tableName = TableName.DB_RESONATOR_SETTING;

        public string Search(CvResonatorSettingProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                            AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);

            return sql;
        }


        public string Delete(CvResonatorSettingProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            return sql;
        }

        public string Insert(CvResonatorSettingProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , PURCHASE_ID
                                        , EFF_NEED
                                        , EFF_MIN_SLOPE
                                        , EFF_MAX_SLOPE
                                        , EFF_MIN_R2
                                        , EFF_MAX_R2
                                        , OC_TEMP_NEED
                                        , OC_TEMP_MIN_SLOPE
                                        , OC_TEMP_MAX_SLOPE
                                        , OC_TEMP_MIN_R2
                                        , OC_TEMP_MAX_R2
                                        , HR_TEMP_NEED
                                        , HR_TEMP_MIN_SLOPE
                                        , HR_TEMP_MAX_SLOPE
                                        , HR_TEMP_MIN_R2
                                        , HR_TEMP_MAX_R2
                                        , COLDPLATE_TEMP_NEED
                                        , COLDPLATE_TEMP_MIN_SLOPE
                                        , COLDPLATE_TEMP_MAX_SLOPE
                                        , COLDPLATE_TEMP_MIN_R2
                                        , COLDPLATE_TEMP_MAX_R2
                                        , RESIDUAL_NEED
                                        , RESIDUAL_MIN_SIGNAL_FW
                                        , RESIDUAL_MAX_SIGNAL_FW
                                        , RESIDUAL_MIN_SIGNAL_BW
                                        , RESIDUAL_MAX_SIGNAL_BW
                                        , RESIDUAL_MIN_PUMP_FW
                                        , RESIDUAL_MAX_PUMP_FW
                                        , RESIDUAL_MIN_PUMP_BW
                                        , RESIDUAL_MAX_PUMP_BW
                                        , CENTERPORT_NEED
                                        , CENTERPORT_SIGNAL_MIN
                                        , CENTERPORT_SIGNAL_MAX
                                        , CENTERPORT_PUMP_MIN
                                        , CENTERPORT_PUMP_MAX
                                        , INCREASE_STEP
                                        , OUTPUT_TEMP_NEED
                                        , OUTPUT_TEMP_MIN_POINT1
                                        , OUTPUT_TEMP_MAX_POINT1
                                        , OUTPUT_TEMP_MIN_POINT2
                                        , OUTPUT_TEMP_MAX_POINT2
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , USER_CREATE
                                        , INUSE

                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.PURCHASE_ID'
                                        , 'dataItem.EFF_NEED'
                                        , 'dataItem.EFF_MIN_SLOPE'
                                        , 'dataItem.EFF_MAX_SLOPE'
                                        , 'dataItem.EFF_MIN_R2'
                                        , 'dataItem.EFF_MAX_R2'
                                        , 'dataItem.OC_TEMP_NEED'
                                        , 'dataItem.OC_TEMP_MIN_SLOPE'
                                        , 'dataItem.OC_TEMP_MAX_SLOPE'
                                        , 'dataItem.OC_TEMP_MIN_R2'
                                        , 'dataItem.OC_TEMP_MAX_R2'
                                        , 'dataItem.HR_TEMP_NEED'
                                        , 'dataItem.HR_TEMP_MIN_SLOPE'
                                        , 'dataItem.HR_TEMP_MAX_SLOPE'
                                        , 'dataItem.HR_TEMP_MIN_R2'
                                        , 'dataItem.HR_TEMP_MAX_R2'
                                        , 'dataItem.COLDPLATE_TEMP_NEED'
                                        , 'dataItem.COLDPLATE_TEMP_MIN_SLOPE'
                                        , 'dataItem.COLDPLATE_TEMP_MAX_SLOPE'
                                        , 'dataItem.COLDPLATE_TEMP_MIN_R2'
                                        , 'dataItem.COLDPLATE_TEMP_MAX_R2'
                                        , 'dataItem.RESIDUAL_NEED'
                                        , 'dataItem.RESIDUAL_MIN_SIGNAL_FW'
                                        , 'dataItem.RESIDUAL_MAX_SIGNAL_FW'
                                        , 'dataItem.RESIDUAL_MIN_SIGNAL_BW'
                                        , 'dataItem.RESIDUAL_MAX_SIGNAL_BW'
                                        , 'dataItem.RESIDUAL_MIN_PUMP_FW'
                                        , 'dataItem.RESIDUAL_MAX_PUMP_FW'
                                        , 'dataItem.RESIDUAL_MIN_PUMP_BW'
                                        , 'dataItem.RESIDUAL_MAX_PUMP_BW'
                                        , 'dataItem.CENTERPORT_NEED'
                                        , 'dataItem.CENTERPORT_SIGNAL_MIN'
                                        , 'dataItem.CENTERPORT_SIGNAL_MAX'
                                        , 'dataItem.CENTERPORT_PUMP_MIN'
                                        , 'dataItem.CENTERPORT_PUMP_MAX'
                                        , 'dataItem.INCREASE_STEP'
                                        , 'dataItem.OUTPUT_TEMP_NEED'
                                        , 'dataItem.OUTPUT_TEMP_MIN_POINT1'
                                        , 'dataItem.OUTPUT_TEMP_MAX_POINT1'
                                        , 'dataItem.OUTPUT_TEMP_MIN_POINT2'
                                        , 'dataItem.OUTPUT_TEMP_MAX_POINT2'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.USER_CREATE'
                                        , 1


                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.EFF_NEED", dataItem.EFF_NEED);
            sql = sql.Replace("dataItem.EFF_MIN_SLOPE", dataItem.EFF_MIN_SLOPE);
            sql = sql.Replace("dataItem.EFF_MAX_SLOPE", dataItem.EFF_MAX_SLOPE);
            sql = sql.Replace("dataItem.EFF_MIN_R2", dataItem.EFF_MIN_R2);
            sql = sql.Replace("dataItem.EFF_MAX_R2", dataItem.EFF_MAX_R2);
            sql = sql.Replace("dataItem.OC_TEMP_NEED", dataItem.OC_TEMP_NEED);
            sql = sql.Replace("dataItem.OC_TEMP_MIN_SLOPE", dataItem.OC_TEMP_MIN_SLOPE);
            sql = sql.Replace("dataItem.OC_TEMP_MAX_SLOPE", dataItem.OC_TEMP_MAX_SLOPE);
            sql = sql.Replace("dataItem.OC_TEMP_MIN_R2", dataItem.OC_TEMP_MIN_R2);
            sql = sql.Replace("dataItem.OC_TEMP_MAX_R2", dataItem.OC_TEMP_MAX_R2);
            sql = sql.Replace("dataItem.HR_TEMP_NEED", dataItem.HR_TEMP_NEED);
            sql = sql.Replace("dataItem.HR_TEMP_MIN_SLOPE", dataItem.HR_TEMP_MIN_SLOPE);
            sql = sql.Replace("dataItem.HR_TEMP_MAX_SLOPE", dataItem.HR_TEMP_MAX_SLOPE);
            sql = sql.Replace("dataItem.HR_TEMP_MIN_R2", dataItem.HR_TEMP_MIN_R2);
            sql = sql.Replace("dataItem.HR_TEMP_MAX_R2", dataItem.HR_TEMP_MAX_R2);
            sql = sql.Replace("dataItem.COLDPLATE_TEMP_NEED", dataItem.COLDPLATE_TEMP_NEED);
            sql = sql.Replace("dataItem.COLDPLATE_TEMP_MIN_SLOPE", dataItem.COLDPLATE_TEMP_MIN_SLOPE);
            sql = sql.Replace("dataItem.COLDPLATE_TEMP_MAX_SLOPE", dataItem.COLDPLATE_TEMP_MAX_SLOPE);
            sql = sql.Replace("dataItem.COLDPLATE_TEMP_MIN_R2", dataItem.COLDPLATE_TEMP_MIN_R2);
            sql = sql.Replace("dataItem.COLDPLATE_TEMP_MAX_R2", dataItem.COLDPLATE_TEMP_MAX_R2);
            sql = sql.Replace("dataItem.RESIDUAL_NEED", dataItem.RESIDUAL_NEED);
            sql = sql.Replace("dataItem.RESIDUAL_MIN_SIGNAL_FW", dataItem.RESIDUAL_MIN_SIGNAL_FW);
            sql = sql.Replace("dataItem.RESIDUAL_MAX_SIGNAL_FW", dataItem.RESIDUAL_MAX_SIGNAL_FW);
            sql = sql.Replace("dataItem.RESIDUAL_MIN_SIGNAL_BW", dataItem.RESIDUAL_MIN_SIGNAL_BW);
            sql = sql.Replace("dataItem.RESIDUAL_MAX_SIGNAL_BW", dataItem.RESIDUAL_MAX_SIGNAL_BW);
            sql = sql.Replace("dataItem.RESIDUAL_MIN_PUMP_FW", dataItem.RESIDUAL_MIN_PUMP_FW);
            sql = sql.Replace("dataItem.RESIDUAL_MAX_PUMP_FW", dataItem.RESIDUAL_MAX_PUMP_FW);
            sql = sql.Replace("dataItem.RESIDUAL_MIN_PUMP_BW", dataItem.RESIDUAL_MIN_PUMP_BW);
            sql = sql.Replace("dataItem.RESIDUAL_MAX_PUMP_BW", dataItem.RESIDUAL_MAX_PUMP_BW);
            sql = sql.Replace("dataItem.CENTERPORT_NEED", dataItem.CENTERPORT_NEED);
            sql = sql.Replace("dataItem.CENTERPORT_SIGNAL_MIN", dataItem.CENTERPORT_SIGNAL_MIN);
            sql = sql.Replace("dataItem.CENTERPORT_SIGNAL_MAX", dataItem.CENTERPORT_SIGNAL_MAX);
            sql = sql.Replace("dataItem.CENTERPORT_PUMP_MIN", dataItem.CENTERPORT_PUMP_MIN);
            sql = sql.Replace("dataItem.CENTERPORT_PUMP_MAX", dataItem.CENTERPORT_PUMP_MAX);
            sql = sql.Replace("dataItem.INCREASE_STEP", dataItem.INCREASE_STEP);
            sql = sql.Replace("dataItem.OUTPUT_TEMP_NEED", dataItem.OUTPUT_TEMP_NEED);
            sql = sql.Replace("dataItem.OUTPUT_TEMP_MIN_POINT1", dataItem.OUTPUT_TEMP_MIN_POINT1);
            sql = sql.Replace("dataItem.OUTPUT_TEMP_MAX_POINT1", dataItem.OUTPUT_TEMP_MAX_POINT1);
            sql = sql.Replace("dataItem.OUTPUT_TEMP_MIN_POINT2", dataItem.OUTPUT_TEMP_MIN_POINT2);
            sql = sql.Replace("dataItem.OUTPUT_TEMP_MAX_POINT2", dataItem.OUTPUT_TEMP_MAX_POINT2);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);




            return sql;

        }
    }
}